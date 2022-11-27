﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessForms.Figures;

namespace ChessForms.Decorators;
public class MouseDownDecorator : AbstractDecorator
{
    Matrix Mat;
    public MouseDownDecorator(IFigureFlyWeight fig, Matrix mat) : base(fig)
    {
        Mat = mat;
    }
    public override void draw(Graphics g, Point coordinates)
    {
        g.TranslateTransform(ChessboardForms.ZEROX, ChessboardForms.ZEROY);
        g.MultiplyTransform(Mat);
        base.draw(g, coordinates);
        g.Transform = new Matrix();
    }
}
