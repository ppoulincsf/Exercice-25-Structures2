using Exercice25;

class Program
{
  
  public const int READ_ITEM = 1;

  public const int QUIT = 0;
  public const int READ_BILL = 1;
  public const int PRINT_BILL = 2;
  public const int SAVE_BILL = 3;
  public const int LOAD_BILL = 4;
  
  public const float TPS_RATE = 0.05f;
  public const float TVQ_RATE = 0.0975f;
  
  public const string BILL_FILE_NAME = "Bill.csv";
  public const string SEPARATOR = ";";
  public static void Main ( string[] args )
  {
    // Question 1.8
    // Écrire le menu principal ici
  }

  public static int AskUserChoice ( string question, int min, int max )
  {
    int userChoice = -1;
    bool inputIsOk = false;
    do
    {
      Console.WriteLine (question);
      string userInput = Console.ReadLine ();
      inputIsOk = int.TryParse (userInput, out userChoice);

    } while (!inputIsOk || userChoice < min || userChoice > max);

    return userChoice;
  }

  /*
  // A décommenter lorsque rendu à la question 1.8
  private static void LoadBill ( Bill bill )
  {
    if (null == bill)
      throw new ArgumentException ("La facture ne peut pas être null");
    string[] allLines = ReadFile (BILL_FILE_NAME);
    InitBill (bill);
    bill.ClientName = allLines[0];
    for(int i=1;i<allLines.Length;i++)
    {
      // Extraire les éléments de la ligne
      string[] elements = allLines[i].Split (SEPARATOR, StringSplitOptions.RemoveEmptyEntries);
      Item item = new Item ();
      item.Description = elements[0];
      item.UnitPrice = float.Parse (elements[1]);
      item.Quantity = int.Parse (elements[2]);
      bill.Items.Add (item);
    }
  }

  private static void SaveBill ( Bill bill )
  {
    if (null == bill)
      throw new ArgumentException ("La facture ne peut pas être null");
    List<string> allLines = new List<string> ();
    allLines.Add (bill.ClientName);
    foreach(Item item in bill.Items)
    {
      string line = item.Description + SEPARATOR + Convert.ToString (item.UnitPrice) + SEPARATOR + Convert.ToInt32 (item.Quantity);
      allLines.Add (line);
    }
    WriteFile (BILL_FILE_NAME, allLines.ToArray ());
  }
  
  
  #region FONCTIONS UTILITAIRES
  /// <summary>
  /// Lit un fichier texte et stocke une ligne par cellule de tableau.
  /// </summary>
  /// <param name="fileName">Nom du fichier à lire. Il doit être situé
  /// dans le dossier bin/Debug/net6.0</param>
  /// <param name="nbLinesMax">Nombres de lignes maximum qui pourront être lues dans le fichier</param>
  /// <returns>Un tableau des lignes lues</returns>
  public static string[] ReadFile ( string fileName)
  {
    StreamReader reader = new StreamReader (fileName, System.Text.Encoding.UTF8);
    List<string> allLines = new List<string> ();

    while (!reader.EndOfStream)
    {
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
      string line = reader.ReadLine ();
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
      allLines.Add(line);

    }

    reader.Close ();

    return allLines.ToArray () ;
  }

  /// <summary>
  /// Écrit un fichier texte à partir d'un tableau de lignes.
  /// </summary>
  /// <param name="fileName">Nom du fichier à écrire. Il sera situé
  /// dans le dossier bin/Debug/net5.0</param>
  /// <param name="linesToWrite">Tableau contenant les lignes à écrire</param>
  public static void WriteFile ( string fileName, string[] linesToWrite )
  {
    StreamWriter writer = new StreamWriter (fileName, false, System.Text.Encoding.UTF8);

    for (int i = 0; i < linesToWrite.Length; i++)
    {
      writer.WriteLine (linesToWrite[i]);
    }

    writer.Close ();
  }
  #endregion
  */
}