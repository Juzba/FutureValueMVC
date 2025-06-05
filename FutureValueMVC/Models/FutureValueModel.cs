using System.ComponentModel.DataAnnotations;

namespace FutureValueMVC.Models;

public class FutureValueModel
{
    [Required(ErrorMessage ="Zadej částku.")]
    [Range(1, 9999999,ErrorMessage = "Částka musí být mezi 1 - 9999999.")]
    public double Investment { get; set; }

    [Required(ErrorMessage ="Zadej úrok.")]
    [Range(0.1,10, ErrorMessage ="Úrok musí být mezi 0.1 - 10%.")]
    public double YearlyRate { get; set; }

    [Required(ErrorMessage ="Zadej Na kolik let.")]
    [Range(1,50,ErrorMessage ="Počet let musí být mezi 1 - 50.")]
    public int YearsNumber { get; set; }




    public double CalculateFutureModel()
    {
        int months = YearsNumber * 12;
        double monthlyRate = YearlyRate / 12 / 100;
        double futureValue = 0;

        for (int i = 0; i < months; i++)
            futureValue = (futureValue + Investment) * (1 + monthlyRate);

        return futureValue;
    }











}



