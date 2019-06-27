using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Repositories
{
    public interface IInformationRepository
    {
        List<DesignDetail> GetListDesign();
        Location GetLocation();
        bool SaveLocation(Location location);
        ProjectInformation GetProjectInformation();
        bool SaveProjectInformation(ProjectInformation projectInformation);
        ContactInformation GetContactInformation();
        bool SaveContactInformation(ContactInformation contactInformation);
    }
}
