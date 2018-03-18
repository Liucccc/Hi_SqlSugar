using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Hi.Repositories;

namespace Hi.Services
{
    public class AdvertiseService : GenericService<zzlh2017_Advertise>,  IAdvertiseService
    {
        private readonly IAdvertiseRepository _repository;
        public AdvertiseService(IAdvertiseRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
