using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaTestyGenerowanie
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            //odbiór eventów z view
            
        }
            #region Public
            #endregion

            #region Private
            #endregion
        }
}
