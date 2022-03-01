using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Color_Generator.ViewModels
{
    public abstract class ViewModelBase : ObservableObject
    {
        public virtual void Dispose() { }
    }
}
