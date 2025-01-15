namespace GeminiAPIs.Interfaces
{
    public interface IAIRepository
    {
        Task<string> DevuelveRespuestaAI(string prompt);
    }
}
