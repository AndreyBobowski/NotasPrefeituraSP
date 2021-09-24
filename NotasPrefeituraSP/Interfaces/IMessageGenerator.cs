using NotasPrefeituraSP.Models;
namespace NotasPrefeituraSP.Interfaces
{
    public interface IMessageGenerator
    {
        public object GenerateMessageObject();

        public void SetSettings(ClientSettings Settings);
    }
}
