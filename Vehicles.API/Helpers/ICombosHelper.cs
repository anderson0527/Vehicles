using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Vehicles.API.Helpers {
    interface ICombosHelper {
        IEnumerable<SelectListItem> GetComboDocumentTypes();

        IEnumerable<SelectListItem> GetComboProcedures();

        IEnumerable<SelectListItem> GetComboVehicleTypes();

        IEnumerable<SelectListItem> GetComboBrands();
    }
}
