namespace TheatricalPlayersRefactoringKata
{
    public interface IPriceCalculator
    {
        decimal CalculateAmount(Performance performance, Play play);
        int CalculateVolumeCredits(Performance performance, Play play);
    }
}