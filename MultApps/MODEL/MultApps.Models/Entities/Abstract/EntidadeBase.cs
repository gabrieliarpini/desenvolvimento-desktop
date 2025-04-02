using MultApps.Models.Enums;
using System;

namespace MultApps.Models.Entities.Abstract
{
        public abstract class EntidadeBase
        {
            public  int id{ get; set; }
            public DateTime DataCriacao { get; set; }
            public DateTime DataAlteracao { get; set; }
            public StatusEnum Status { get; set; }
    }
}
