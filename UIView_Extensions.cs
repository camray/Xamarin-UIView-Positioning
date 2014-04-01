using System;
using System.Drawing;
using MonoTouch.UIKit;

namespace MonoTouch.UIKit
{
  public static class UIViewExtensions
  {
    public static void X(this UIView view, float x)
    {
      RectangleF r = view.Frame;
      r.X = x;
      view.Frame = r;
    }

    public static void Y(this UIView view, float y)
    {
      RectangleF r = view.Frame;
      r.Y = y;
      view.Frame = r;
    }

    public static void Width(this UIView view, float width)
    {
      RectangleF r = view.Frame;
      r.Width = width;
      view.Frame = r;
    }

    public static void Height(this UIView view, float height)
    {
      RectangleF r = view.Frame;
      r.Height = height;
      view.Frame = r;
    }

    public static void Origin(this UIView view, PointF dim)
    {
      RectangleF r = view.Frame;
      r.X = dim.X;
      r.Y = dim.Y;
      view.Frame = r;
    }

    public static void Size(this UIView view, SizeF dim)
    {
      RectangleF r = view.Frame;
      r.Width = dim.Width;
      r.Height = dim.Height;
      view.Frame = r;
    }

    public static void Right(this UIView view, float right)
    {
      RectangleF r = view.Frame;
      r.X = right - view.Frame.Width;
      view.Frame = r;
    }

    public static void Bottom(this UIView view, float bottom)
    {
      RectangleF r = view.Frame;
      r.Y = bottom - view.Frame.Height;
      view.Frame = r;
    }

    public static void CenterY(this UIView view, float y)
    {
      view.Center = new PointF (view.Center.X, y);
    }

    public static void CenterX(this UIView view, float x)
    {
      view.Center = new PointF (x, view.Center.Y);
    }

    public static float X(this UIView view)
    {
      return view.Frame.X;
    }

    public static float Y(this UIView view)
    {
      return view.Frame.Y;
    }

    public static float Width(this UIView view)
    {
      return view.Frame.Width;
    }

    public static float Height(this UIView view)
    {
      return view.Frame.Height;
    }

    public static PointF Origin(this UIView view)
    {
      return new PointF (view.Frame.X, view.Frame.Y);
    }

    public static PointF Size(this UIView view)
    {
      return new PointF(view.Frame.Width, view.Frame.Height);
    }

    public static float Right(this UIView view)
    {
      return view.Frame.X + view.Frame.Width;
    }

    public static float CenterX(this UIView view)
    {
      return view.Center.X;
    }

    public static float CenterY(this UIView view)
    {
      return view.Center.Y;
    }

    public static UIView LastSubviewOnY(this UIView view) {
      if(view.Subviews.Length > 0){
        UIView outView = view.Subviews[0];
        foreach (var v in view.Subviews) {
          if(v.Frame.Y > outView.Frame.Y)
            outView = v;
        }

        return outView;
      }

      return null;
    }

    public static UIView LastSubviewOnX(this UIView view) {
      if(view.Subviews.Length > 0){
        UIView outView = view.Subviews[0];
        foreach (var v in view.Subviews) {
          if(v.Frame.X > outView.Frame.X)
            outView = v;
        }

        return outView;
      }

      return null;
    }

    public static void CenterToParent(this UIView view) {
      if (view.Superview != null) {
        RectangleF frame = view.Frame;
        switch (UIApplication.SharedApplication.StatusBarOrientation) {
        case UIInterfaceOrientation.LandscapeLeft:
        case UIInterfaceOrientation.LandscapeRight:
          frame.X = (view.Superview.Frame.Height / 2) - (view.Frame.Width / 2);
          frame.Y = (view.Superview.Frame.Width / 2) - (view.Frame.Height / 2);
          break;
        case UIInterfaceOrientation.Portrait:
        case UIInterfaceOrientation.PortraitUpsideDown:
          frame.X = (view.Superview.Frame.Width / 2) - (view.Frame.Width / 2);
          frame.Y = (view.Superview.Frame.Height / 2) - (view.Frame.Height / 2);
          break;
        }
        view.Frame = frame;
      } else {
        throw new Exception ("Can't center to parent. Ensure you have added this view to a superview.");
      }
    }

  }
}

