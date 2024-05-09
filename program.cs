static void Main() 
{
  //Karar_Yapıları_2
    #region Switch-Case

    int month = DateTime.Now.Month;
    // kontrol etmek istediğimiz koşulu switche yazıyoruz
    // caselerde switchteki değişkenin değişken türüne göre işlem yapar
    switch(month)
    {
        case 1:
            Console.WriteLine("Ocak ayındaysınız.");
            break;
        case 2:
            Console.WriteLine("Şubat ayındaysınız.");
            break;
        case 3:
            Console.WriteLine("Mart ayındaysınız.");
                break;
        case 4:
            Console.WriteLine("Nisan ayındaysınız.");
            break;
        case 5:
            Console.WriteLine("Mayıs ayındaysınız.");
            break;
        default: Console.WriteLine("Yanlış veri girdiniz");
            break ;
