﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessForms.Figures;

namespace ChessForms.Decorators;
public class AbstractDecorator : IFigureFlyWeight
{
    private IFigureFlyWeight Figure;
    public AbstractDecorator(IFigureFlyWeight fig)
    {
        Figure = fig;
    }

    public virtual void draw(Graphics g,Point coordinates)
    {
        Figure.draw(g,coordinates);
    }

    public virtual IFigureFlyWeight Unbox()
    {
        return Figure.Unbox();
    }
}
