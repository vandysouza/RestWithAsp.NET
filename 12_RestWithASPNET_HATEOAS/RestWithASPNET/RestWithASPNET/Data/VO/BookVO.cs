using RestWithASPNET.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;

namespace RestWithASPNET.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string Autor { get; set; }

        public DateTime dataLançamento { get; set; }

        public decimal Valor { get; set; }

        public string Título { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
