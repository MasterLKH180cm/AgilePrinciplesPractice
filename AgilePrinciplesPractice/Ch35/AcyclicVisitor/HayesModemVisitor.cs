﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgilePrinciplesPractice.Ch35.Visitor;

namespace AgilePrinciplesPractice.Ch35.AcyclicVisitor
{
    public interface HayesModemVisitor : ModemVisitor
    {
        void Visit(HayesModem m);
    }
}