namespace LojaLanches.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string? Teste { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}