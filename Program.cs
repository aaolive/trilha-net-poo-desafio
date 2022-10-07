using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// smartphone nokia
Nokia smartphoneNokia= new Nokia("779956352","Nokia 5.3","85229653274",128);

//smartphone iphone
Iphone smartphoneIphone=new Iphone("81963524822","Iphone 12","741236589612",128);

// usando smartphone nokia
smartphoneNokia.UsarSmartphone();
smartphoneNokia.ReceberLigacao();
smartphoneNokia.Ligar();
smartphoneNokia.InstalarAplicativo("Facebook");

Console.WriteLine();

// usando smartphone Iphone
smartphoneIphone.UsarSmartphone();
smartphoneIphone.Ligar();
smartphoneIphone.ReceberLigacao();
smartphoneIphone.InstalarAplicativo("TikTok");
