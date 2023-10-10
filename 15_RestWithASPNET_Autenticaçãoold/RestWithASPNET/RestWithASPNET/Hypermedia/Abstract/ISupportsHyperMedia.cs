using RestWithASPNET.Hypermedia;

namespace RestWithASPNETUdemy.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}

