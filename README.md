Text Translator

Project Structure
1. Project Name: TranslateASPMVC
2. Model: Contains the logic for translation.
   https://github.com/somsak412/Translator/blob/master/TranslateASPMVC/Models/Translator.cs
  
4. Controller: Handles user input and interacts with the model.
   https://github.com/somsak412/Translator/blob/master/TranslateASPMVC/Controllers/TranslateController.cs

5. View: Presents the user interface.
   https://github.com/somsak412/Translator/blob/master/TranslateASPMVC/Views/Translate/Index.cshtml

How the Solution Works
1. Input Handling: The user inputs text into a form on the Index view.
2. Form Submission: The form is submitted to the Index action of the TranslateController.
3. Translation Logic: The controller creates a Translator object, sets the OriginalText, and calls the Translate method.
4. Translation Method:
    Prefix: Adds the prefix "UBCO".
    Vowel Doubling: Doubles each vowel in the original text.
    Consonant Shifting: Shifts each consonant to the next consonant in the alphabet.
    Word Count: Appends the number of words in the original text.
5. Result Display: The translated text is passed to the view through ViewBag and displayed to the user.

Technical Decisions
1. MVC Pattern: The Model-View-Controller pattern separates concerns, making the application easier to maintain and extend.
2. StringBuilder: Used for efficient string manipulation during the translation process.
3. Character Handling: Separate methods for handling vowels and consonants to keep the logic clear and maintainable.
4. ViewBag: Used for simplicity to pass the translated text to the view. 
    
