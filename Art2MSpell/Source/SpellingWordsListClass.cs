using System.Reflection;
using Art2MSpell.Classes;

public class SpellingWordsListClass
{
    /// <summary>
    ///     write spelling words from collection to file.
    /// </summary>
    /// <param name="filePath">The path to the spelling list file.</param>
    /// <returns>true if spelling list is written to file else false.</returns>
    /// <created>art2m,5/12/2019</created>
    /// <changed>art2m,5/12/2019</changed>
    public bool WriteWordsToFile(string filePath)
    {
        var srw = new SpellingReadWriteClass();

        MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
        if (!srw.WriteToFile(filePath))
        {
            return false;
        }

        const string MsgSuccess = "Your spelling list has been created successfully.";
        MyMessages.ShowInformationMessage(MsgSuccess, MyMessages.NameOfMethod);
        return true;
    }
}