using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using DrawingTestApp.CustomUI;
using DrawingTestApp.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomContentView), typeof(CustomContentViewRenderer))]
namespace DrawingTestApp.Droid.CustomRenderer
{
    public class CustomContentViewRenderer : ViewRenderer<CustomContentView, Android.Views.TextureView>
    {
        public CustomContentViewRenderer(Context context) : base(context)
        {
            this.SetWillNotDraw(false);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //base.OnElementPropertyChanged(sender, e);
            this.Invalidate();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CustomContentView> e)
        {
            //base.OnElementChanged(e);
            this.Invalidate();
        }

        protected override void OnDraw(Canvas canvas)
        {
            var element = this.Element;

            var frame = (Frame)element.Content.FindByName("clearFrame");

            int hPixel = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, (float)frame.Height, Context.Resources.DisplayMetrics);
            int wPixel = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, (float)frame.Width, Context.Resources.DisplayMetrics);

            int cPixel = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, (float)frame.CornerRadius, Context.Resources.DisplayMetrics);

            var rect = new Rect();
            this.GetDrawingRect(rect);

            var paint = new Paint()
            {
                Color = Android.Graphics.Color.Argb(115, 5, 5, 5),
                AntiAlias = true
            };

            canvas.DrawRect(new RectF(rect), paint);

            Rect innerRect = new Rect();
            this.GetDrawingRect(innerRect);

            var x = (innerRect.Right / 2) - (wPixel / 2);
            var y = (innerRect.Bottom / 2) - (hPixel / 2);
            var x2 = (innerRect.Right / 2) + (wPixel / 2);
            var y2 = (innerRect.Bottom / 2) + (hPixel / 2);

            innerRect.Bottom = y2;
            innerRect.Right = x;
            innerRect.Top = y;
            innerRect.Left = x2;


            var innerPaint = new Paint()
            {
                Color = Android.Graphics.Color.Transparent,
                AntiAlias = true
            };

            innerPaint.SetXfermode(new PorterDuffXfermode(PorterDuff.Mode.SrcOut));

            canvas.DrawRoundRect(new RectF(innerRect), (float)cPixel, (float)cPixel, innerPaint);
        }
    }
}