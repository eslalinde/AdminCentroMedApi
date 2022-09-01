using AdminCentroMed.Locations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdminCentroMed.Seed
{
    public partial class LocationDataSeederContributor
    {
        public ICollection<Country> GetCountries(Guid? tenantId)
        {
            return new List<Country> {
                new(id: _guidGenerator.Create(), tenantId: tenantId, name: "Colombia", code: "CO", normalizeName: "COLOMBIA")
            };
        }

        public ICollection<State> GetColombiaStates(string countryName, Guid? tenantId, Guid countryId)
        {
            return GetColombiaStatesInternal(tenantId, countryId)
                .Where(x => x.Item1.Equals(countryName, StringComparison.OrdinalIgnoreCase))
                .Select(x => x.Item2)
                .ToList();
        }

        private ICollection<(string, State)> GetColombiaStatesInternal(Guid? tenantId, Guid countryId)
        {
            return new List<(string, State)> {
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Amazonas", countryId, "AMAZONAS")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Antioquia", countryId, "ANTIOQUIA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Arauca", countryId, "ARAUCA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Atlántico", countryId, "ATLANTICO")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Bolívar", countryId, "BOLIVAR")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Boyacá", countryId, "BOYACA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Caldas", countryId, "CALDAS")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Caquetá", countryId, "CAQUETA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Casanare", countryId, "CASANARE")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Cauca", countryId, "CAUCA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Cesar", countryId, "CESAR")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Chocó", countryId,"CHOCO")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Córdoba", countryId,"CORDOBA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Cundinamarca", countryId, "CUNDINAMARCA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Guainía", countryId, "GUAINIA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Guaviare", countryId, "GUAVIARE")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Huila", countryId, "HUILA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "La Guajira", countryId, "LAGUAJIRA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Magdalena", countryId, "MAGDALENA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Meta", countryId, "META")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Nariño", countryId, "NARINO")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Norte de Santander", countryId, "NORTEDESANTANDER")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Putumayo", countryId, "PUTUMAYO")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Quindío", countryId, "QUINDIO")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Risaralda", countryId, "RISARALDA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Santander", countryId, "SANTANDER")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Sucre", countryId, "SUCRE")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Tolima", countryId, "TOLIMA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Valle del Cauca", countryId, "VALLEDELCAUCA")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Vaupés", countryId, "VAUPES")),
                new("Colombia", new (_guidGenerator.Create(), tenantId, "Vichada", countryId, "VICHADA")),
            };
        }

        public ICollection<City> GetCities(string stateName, Guid? tenantId, Guid countryId, Guid stateId)
        {
            return GetAllCitiesInternal(tenantId, countryId, stateId)
                .Where(x => x.Item1.Equals(stateName, StringComparison.OrdinalIgnoreCase))
                .Select(x => x.Item2)
                .ToList();
        }

        private ICollection<(string, City)> GetAllCitiesInternal(Guid? tenantId, Guid countryId, Guid stateId)
        {
            return new List<(string, City)>
            {
                new( "Amazonas", new(_guidGenerator.Create(), tenantId, "Leticia", stateId, countryId, "LETICIA")),
                new( "Arauca", new(_guidGenerator.Create(), tenantId, "Arauca", stateId, countryId, "ARAUCA")),
                new( "Atlántico", new(_guidGenerator.Create(), tenantId, "Barranquilla", stateId, countryId, "BARRANQUILLA")),
                new( "Bolívar", new(_guidGenerator.Create(), tenantId, "Cartagena de Indias", stateId, countryId, "CARTAGENADEINDIAS")),
                new( "Boyacá", new(_guidGenerator.Create(), tenantId, "Tunja", stateId, countryId, "TUNJA")),
                new( "Caldas", new(_guidGenerator.Create(), tenantId, "Manizales", stateId, countryId, "MANIZALES")),
                new( "Caquetá", new(_guidGenerator.Create(), tenantId, "Florencia", stateId, countryId, "FLORENCIA")),
                new( "Casanare", new(_guidGenerator.Create(), tenantId, "Yopal", stateId, countryId, "YOPAL")),
                new( "Cauca", new(_guidGenerator.Create(), tenantId, "Popayán", stateId, countryId, "POPAYAN")),
                new( "Cesar", new(_guidGenerator.Create(), tenantId, "Valledupar", stateId, countryId, "VALLEDUPAR")),
                new( "Chocó", new(_guidGenerator.Create(), tenantId, "Quibdó", stateId, countryId, "QUIBDO")),
                new( "Córdoba", new(_guidGenerator.Create(), tenantId, "Montería", stateId, countryId, "MONTERIA")),
                new( "Guainía", new(_guidGenerator.Create(), tenantId, "Inírida", stateId, countryId, "INIRIDA")),
                new( "Guaviare", new(_guidGenerator.Create(), tenantId, "San José del Guaviare", stateId, countryId, "SANJOSEDELGUAVIARE")),
                new( "Huila", new(_guidGenerator.Create(), tenantId, "Neiva", stateId, countryId, "NEIVA")),
                new( "La Guajira", new(_guidGenerator.Create(), tenantId, "Riohacha", stateId, countryId, "RIOACHA")),
                new( "Magdalena", new(_guidGenerator.Create(), tenantId, "Santa Marta", stateId, countryId, "SANTAMARTA")),
                new( "Meta", new(_guidGenerator.Create(), tenantId, "Villavicencio", stateId, countryId, "VILLAVICENCIO")),
                new( "Nariño", new(_guidGenerator.Create(), tenantId, "San Juan de Pasto", stateId, countryId, "SANJUANDEPASTO")),
                new( "Norte de Santander", new(_guidGenerator.Create(), tenantId, "San José de Cúcuta", stateId, countryId, "SANJOSEDECUCUTA")),
                new( "Putumayo", new(_guidGenerator.Create(), tenantId, "Mocoa", stateId, countryId, "MOCOA")),
                new( "Quindío", new(_guidGenerator.Create(), tenantId, "Armenia", stateId, countryId, "ARMENIA")),
                new( "Risaralda", new(_guidGenerator.Create(), tenantId, "Pereira", stateId, countryId, "PEREIRA")),
                new( "Santander", new(_guidGenerator.Create(), tenantId, "Bucaramanga", stateId, countryId, "BUCARAMANGA")),
                new( "Sucre", new(_guidGenerator.Create(), tenantId, "Sincelejo", stateId, countryId, "SINCELEJO")),
                new( "Tolima", new(_guidGenerator.Create(), tenantId, "Ibagué", stateId, countryId, "IBAGUE")),
                new( "Vaupés", new(_guidGenerator.Create(), tenantId, "Mitú", stateId, countryId, "MITU")),
                new( "Vichada", new(_guidGenerator.Create(), tenantId, "Puerto Carreño", stateId, countryId, "PUERTOCARRENO")),

                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Medellín", stateId, countryId, "MEDELLIN")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Sabaneta", stateId, countryId, "SABANETA")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Caldas", stateId, countryId, "CALDAS")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "La Estrella", stateId, countryId, "LAESTRELLA")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Itagüí", stateId, countryId, "ITAGUI")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Bello", stateId, countryId, "BELLO")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Copacabana", stateId, countryId, "COPACABANA")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Girardota", stateId, countryId, "GIRARDOTA")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Barbosa", stateId, countryId, "BARBOSA")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Rionegro", stateId, countryId, "RIONEGRO")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Guarne", stateId, countryId, "GUARNE")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Marinilla", stateId, countryId, "MARINILLA")),
                new( "Antioquia", new(_guidGenerator.Create(), tenantId, "Envigado", stateId, countryId, "ENVIGADO")),

                new( "Atlántico", new(_guidGenerator.Create(), tenantId, "Soledad", stateId, countryId, "SOLEDAD")),
                new( "Atlántico", new(_guidGenerator.Create(), tenantId, "Puerto Colombia", stateId, countryId, "PUERTOCOLOMBIA")),
                new( "Atlántico", new(_guidGenerator.Create(), tenantId, "Malambo", stateId, countryId, "MALAMBO")),
                new( "Atlántico", new(_guidGenerator.Create(), tenantId, "Galapa", stateId, countryId, "GALAPA")),

                new( "Valle del Cauca", new(_guidGenerator.Create(), tenantId, "Cali", stateId, countryId, "CALI")),
                new( "Valle del Cauca", new(_guidGenerator.Create(), tenantId, "Jamundí", stateId, countryId, "JAMUNDI")),
                new( "Valle del Cauca", new(_guidGenerator.Create(), tenantId, "Candelaria", stateId, countryId, "CANDELARIA")),
                new( "Valle del Cauca", new(_guidGenerator.Create(), tenantId, "Palmira", stateId, countryId, "PALMIRA")),
                new( "Valle del Cauca", new(_guidGenerator.Create(), tenantId, "Yumbo", stateId, countryId, "YUMBO")),
                new( "Valle del Cauca", new(_guidGenerator.Create(), tenantId, "La Cumbre", stateId, countryId, "LACUMBRE")),
                new( "Valle del Cauca", new(_guidGenerator.Create(), tenantId, "Vijes", stateId, countryId, "VIJES")),

                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Bogotá", stateId, countryId, "BOGOTA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Madrid", stateId, countryId, "MADRID")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "La Vega", stateId, countryId, "LAVEGA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Funza", stateId, countryId, "FUNZA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Mosquera", stateId, countryId, "MOSQUERA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Tocancipá", stateId, countryId, "TOCANCIPA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Madrid", stateId, countryId, "MADRID")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Tenjo", stateId, countryId, "TENJO")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Sopó", stateId, countryId, "SOPO")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Soacha", stateId, countryId, "SOACHA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Facatativá", stateId, countryId, "FACATATIVA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Zipaquirá", stateId, countryId, "ZIPAQUIRA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Chía", stateId, countryId, "CHIA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Cajicá", stateId, countryId, "CAJICA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Sibaté", stateId, countryId, "SIBATE")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "La Calera", stateId, countryId, "LACALERA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Sopó", stateId, countryId, "SOPO")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Tabio", stateId, countryId, "TABIO")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Cota", stateId, countryId, "COTA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Gachanchipá", stateId, countryId, "GACHANCHIPA")),
                new( "Cundinamarca", new(_guidGenerator.Create(), tenantId, "Bojacá", stateId, countryId, "BOJACA")),
           };
        }
    }
}