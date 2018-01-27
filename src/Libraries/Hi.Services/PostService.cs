using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi.Domain.Entities;
using Hi.Repositories;

namespace Hi.Services
{
    public class PostService : GenericService<Post>, IPostService
    {
        private readonly IPostRepository _repository;
        public PostService(IPostRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
