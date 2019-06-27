using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;
using Template_RealEstate_20052019.Models;

namespace Template_RealEstate_20052019.Repositories
{
    public class InformationRepository : IInformationRepository
    {
        private const string keyProjectInformation = "PROJECT_INFORMATION";
        private const string keyContactInformation = "CONTACT_INFORMATION";
        private const string keyLocation = "LOCATION";
        private readonly IKeyValueRepository _keyValueRepository;

        public InformationRepository(IKeyValueRepository keyValueRepository)
        {
            this._keyValueRepository = keyValueRepository;
        }
        public ContactInformation GetContactInformation()
        {
            var strData = _keyValueRepository.GetByKey(keyContactInformation);
            if (string.IsNullOrEmpty(strData))
            {
                return new ContactInformation();
            }

            return JsonConvert.DeserializeObject<ContactInformation>(strData);
        }

        public List<DesignDetail> GetListDesign()
        {
            return new List<DesignDetail>();
        }

        public Location GetLocation()
        {
            var strData = _keyValueRepository.GetByKey(keyLocation);
            if (string.IsNullOrEmpty(strData))
            {
                return new Location();
            }

            return JsonConvert.DeserializeObject<Location>(strData);
        }

        public ProjectInformation GetProjectInformation()
        {
            var strData = _keyValueRepository.GetByKey(keyProjectInformation);
            if (string.IsNullOrEmpty(strData))
            {
                return new ProjectInformation();
            }

            return JsonConvert.DeserializeObject<ProjectInformation>(strData);
        }

        public bool SaveContactInformation(ContactInformation contactInformation)
        {
            if (contactInformation == null)
            {
                return false;
            }

            _keyValueRepository.Save(keyContactInformation, JsonConvert.SerializeObject(contactInformation));

            return true;
        }

        public bool SaveLocation(Location location)
        {
            if (location == null)
            {
                return false;
            }

            _keyValueRepository.Save(keyLocation, JsonConvert.SerializeObject(location));

            return true;
        }

        public bool SaveProjectInformation(ProjectInformation projectInformation)
        {
            if (projectInformation == null)
            {
                return false;
            }

            _keyValueRepository.Save(keyProjectInformation, JsonConvert.SerializeObject(projectInformation));

            return true;
        }
    }
}
