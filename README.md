Xamarin-UIView-Positioning
==========================

UIView extensions for Xamarin + Mono projects

Based on [UIView+Positioning](https://github.com/freak4pc/UIView-Positioning)

Usage

```
var x = new UIView (new RectangleF (0, 0, 100, 100));
View.AddSubview (x);

x.X(10); // Moves left 10 px
Console.WriteLine(x.X().ToString());
// 10

x.Y(10); // Moves down 10 px
Console.WriteLine(x.Y().ToString());
// 10

x.Width(10); // Sets width = 10 px
Console.WriteLine(x.Width().ToString());
// 10

x.Height(10); // Sets height = 10 px
Console.WriteLine(x.Height().ToString());
// 10

x.Origin(new PointF(10, 15)); // moves to x = 10, y = 15
Console.WriteLine(x.Origin().ToString());
// PointF 10, 15

x.Size(new PointF(10, 15)); // Sets width = 10, height = 15
Console.WriteLine(x.Size().ToString());
// PointF 10, 15

x.Right(10); // Sets right bound to 10 px
Console.WriteLine(x.Right().ToString());
// 10

x.Bottom(10); // Sets bottom bound to 10 px
Console.WriteLine(x.Bottom().ToString());
// 10

x.CenterX(10); // Sets the center x cord to 10 px
Console.WriteLine(x.CenterX().ToString());
// 10

x.CenterY(10); // Sets the center y cord to 10 px
Console.WriteLine(x.CenterY().ToString());
// 10

Console.WriteLine(x.LastSubviewOnY().ToString());
// Outputs the bottommost subview

Console.WriteLine(x.LastSubviewOnX().ToString());
// Outputs the rightmost subview

x.CenterToParent();
// Centers a view horizontally and vertically to its parent. Must be added to a view before this is called.

```
