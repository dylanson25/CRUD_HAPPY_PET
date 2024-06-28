using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_HAPPY_PET.Views
{
    public interface IMainView
    {
        event EventHandler ShowPetView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowVetsView;
    }
}
