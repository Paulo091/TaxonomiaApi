﻿using Taxonomia.Domain.Base.Models;
using Taxonomia.Domain.EspecieEntity;
using Taxonomia.Domain.FamiliaEntity;
using Taxonomia.Domain.TaxonomiaEntity;

namespace Taxonomia.Domain.GeneroEntity
{
    public class Genero : TaxonomiaBaseEntity
    {        
        public Guid FamiliaId { get; private set; }
        public Familia Familia { get; private set; }
        public ICollection<Especie> Especie { get; private set; }
    }
}
