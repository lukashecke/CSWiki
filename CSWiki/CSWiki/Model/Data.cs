using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CSWiki.Model
{
    public class Data
    {
        #region Properties

        private DataSet database;

        public DataSet Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataSet("CSWiki");
                }

                return database;
            }
        }

        #endregion

        #region Ctor

        public Data ()
        {
            var dataTable = CreateTable();
            Database.Tables.Add(dataTable);

            // Zum Anlegen neuer Einträge

            /*  this.InsertDataRow(dataTable,
                "query",
                "description",
                "example",
                "-\tinformation\r\n\r\n");
             * */
            
            this.InsertDataRow(dataTable,
               "Boxing",
               "Beim Boxing handelt es sich um die Konvertierung eines Werttyps (primitiver Datentyp) in den Typ object oder in einen beliebigen anderen Schnittstellentyp, der durch diesen Werttyp implementiert wird. Wenn die CLR für einen Werttyp das Boxing durchführt, wird der Wert mit einer System.Object-Instanz umschlossen und im verwalteten Heap gespeichert. Durch Unboxing wird der Werttyp aus dem Objekt extrahiert. Boxing ist implizit, Unboxing ist explizit. Das Konzept von Boxing und Unboxing unterliegt der einheitlichen C#-Ansicht des Typsystems, in dem ein Wert eines beliebigen Typs als Objekt behandelt werden kann.",
               "// The following line boxes i.\r\nint i = 123;\r\nobject o = i;\n\n// unboxing\r\no = 123;\r\ni = (int)o;",
               "Im Verhältnis zu einfachen Zuweisungen sind Boxing und Unboxing rechentechnisch aufwändige Prozesse. Wenn ein Werttyp mittels Boxing konvertiert wird, muss ein neues Objekt zugeordnet und erstellt werden. Die für Unboxing erforderliche Umwandlung ist ebenfalls, jedoch in geringerem Maße rechentechnisch aufwändig. Weitere Informationen finden Sie unter Leistung.");
            this.InsertDataRow(dataTable,
               "Exeptionlogging",
               "In den meisten Fällen fängst du einen Fehler, also programmierst ein try/catch, erstellst anschließend einen Log-Eintrag, der protokolliert, dass ein Fehler aufgetreten ist, und wirfst dann den Fehler erneut. Die alte Exception wird somit als InnerException mitgegeben, wodurch man die Stack Trace Eigenschaft mit genaueren Informationen über den fehler und den Call Stack erhält. Das hilft bei der Fehlersuche!",
               "try {\r\n\t// Fehler\r\n}\r\ncatch (Exception ex) {\r\n\t// Logging\r\n\tthrow new Exception(\"Infos\", ex);\r\n}",
               "Allgemeiner Informatinen in den anderen Exception-Einträgen");
            this.InsertDataRow(dataTable,
               "Exceptionthrowing",
               "Manchmal kann es hilfreich sein, selber Exceptions zu werfen die auf Fehler in der Verwendung aufmerksam machen",
               "static void WriteHello(string name) {\r\n\tif (String.IsNullOrEmpty(name))\r\n\t\tthrow new ArgumentNullException(\"name\");\r\n\tConsole.WriteLine(\"Hello {0}\", name);\r\n}",
               "-\tEigene Exception-Klassen müssen immer von einer -, oder DER Exception Klasse erben und sollten mit \"Exception\" enden.\r\n\r\n");
            this.InsertDataRow(dataTable,
               "Exceptionhandeling",
               "Die try-catch-Anweisung besteht aus einem try-Block gefolgt von einer oder mehreren catch-Klauseln, die Handler f\u00FCr verschiedene Ausnahmen angeben.\r\n\r\nWenn eine Ausnahme ausgel\u00F6st wird, sucht die Common Language Runtime (CLR) nach der catch-Anweisung, die diese Ausnahme behandelt. Wenn die derzeit ausgef\u00FChrte Methode keinen solchen catch-Block enth\u00E4lt, betrachtet die CLR die Methode, die die aktuelle Methode aufgerufen hat, dann die vorhergehende in der Aufrufliste usw. Wenn kein catch-Block gefunden wird, zeigt die CLR dem Benutzer eine Meldung \u00FCber eine nicht behandelte Ausnahme an und beendet die Ausf\u00FChrung des Programms.",
               "// Code, der den Fehler wirft\r\ntry {\r\n\tstring text = System.IO.File.ReadAllText(@\"c:myFile.txt\");\r\n\tConsole.WriteLine(\"Der Text in der Datei lautet:\");\r\n\tConsole.WriteLine(text);\r\n}\r\n// Hier findet die Fehlerbehandlung statt\r\ncatch (Exception e) { \r\n\t// Das Objekt e beinhaltet die Informationen zum Fehler\r\n\tConsole.WriteLine(\"Hoppala. Da gibt es ein Problem:\");\r\n\tConsole.WriteLine(e.Message);\r\n}\r\n// Dieser Code wir immer aufgerufen\r\nfinally {\r\n}\r\n// Hier l\u00E4uft das Programm normal weier",
               "-\t\"Exception\" ist die Basisklasse aller Fehler\r\n\r\n-\tDer finally-Block ist optional\r\n\r\n-\tWerden Exceptionobjekte nicht benötigt, können diese auch einfach weggelassen werden\r\n\r\n-\tSeit C# 6 kann man Fehler der gleichen Exception mit dem Schlüsselwort \"when\"Unterscheiden\r\n\r\n-\tElemente, die mit einfachen Abfragen geprüft werden können, nicht mit try/catch prüfen, da dies durch die Aufarbeitung des Stack Traces sehr aufwendig und kein sauberer Programmierstil ist! Besser \"Exceptionthrowing\" :)\r\n\r\n");
            this.InsertDataRow(dataTable,
               "MVVM",
               "Model View ViewModel (MVVM) ist ein Entwurfsmuster und eine Variante des Model-View-Controller-Musters (MVC). Es dient zur Trennung von Darstellung und Logik der Benutzerschnittstelle (UI). Es zielt auf moderne UI-Plattformen wie Cocoa, Windows Presentation Foundation (WPF), JavaFX, und HTML5 ab, da ein Datenbindungsmechanismus erforderlich ist. Gegenüber dem MVC-Muster kann die Testbarkeit verbessert und der Implementierungsaufwand reduziert werden, da keine separaten Controller-Instanzen erforderlich sind. MVVM erlaubt eine Rollentrennung von UI-Designern und Entwicklern, wodurch Anwendungsschichten von verschiedenen Arbeitsgruppen entwickelt werden können. Designer können einen Fokus auf User Experience setzen und Entwickler die UI- und Geschäftslogik schreiben\n\nDas MVVM nutzt die funktionale Trennung des MVC-Musters von Model und View. Zum Erreichen einer losen Kopplung zwischen diesen Komponenten wird ein Datenbindungsmechanismus verwendet. Das MVVM-Muster enth\u00E4lt folgende drei Komponenten:\r\n\r\n\nModel: Datenzugriffsschicht f\u00FCr die Inhalte, die dem Benutzer angezeigt und von ihm manipuliert werden. Dazu benachrichtigt es \u00FCber Daten\u00E4nderungen und f\u00FChrt eine Validierung der vom Benutzer \u00FCbergebenen Daten durch. Es enth\u00E4lt die gesamte Gesch\u00E4ftslogik und ist f\u00FCr sich alleine durch Unit Tests \u00FCberpr\u00FCfbar.\r\n\r\n\nView: Alle durch die grafische Benutzeroberfl\u00E4che (GUI) angezeigten Elemente. Es bindet sich an Eigenschaften des ViewModel, um Inhalte darzustellen und zu manipulieren sowie Benutzereingaben weiterzuleiten. Durch die Datenbindung ist die View einfach austauschbar und ihr Code-Behind gering.\r\n\r\n\nViewModel: Enth\u00E4lt die UI-Logik (Model der View) und dient als Bindeglied zwischen View und obigem Model. Einerseits tauscht es Information mit dem Model aus, ruft also Methoden oder Dienste auf. Andererseits stellt es der View \u00F6ffentliche Eigenschaften und Befehle zur Verf\u00FCgung. Diese werden von der View an Steuerelemente gebunden, um Inhalte auszugeben bzw. UI-Ereignisse weiterzuleiten. Das ViewModel darf dabei keinerlei Kenntnis der View besitzen.\r\n\r\n\nDas MVVM-Muster kann als technologie-spezifisch bezeichnet werden, da f\u00FCr die Verkn\u00FCpfung von View und ViewModel ein Datenbindungsmechanismus ben\u00F6tigt wird. Diese Infrastruktur wird h\u00E4ufig als Binder bezeichnet[2]. Im Detail handelt es sich hierbei um einen bidirektionalen Einsatz des Beobachter-Musters. Binder, welche eine Datenbindung auf Basis von deklarativen Angaben etablieren k\u00F6nnen, sind f\u00FCr verschiedene Techniken vorhanden. ",
               "Die App selbst ist ein gutes Beispiel für MVVM. In der Solution kann man dies unter anderem durch die Ordnerstruktur erkennen.",
               "-\tDas MVVM wurde 2005 von Microsoft MVP John Gossman veröffentlicht. Es ist eine Spezialisierung des Presentation Model von Martin Fowler[1] und ist mit diesem insofern identisch, als beide Muster Zustand und Verhalten der View in ein separates UI-Model (Presentation bzw. View Model) verschieben. Das Presentation Model ermöglicht allerdings das Erzeugen einer View unabhängig von der UI-Plattform, wohingegen das MVVM ursprünglich auf UIs mittels WPF abzielt. Es findet allerdings inzwischen auch in anderen Bereichen Anwendung, ähnlich wie bei MVC. \r\n\r\n");
            this.InsertDataRow(dataTable,
               "Interface",
               "Interfaces (dt. Schnttstellen genannt) sind ähnlich den abstrakten Klassen, beinhalten jedoch keinerlei Implementierung",
               "\r\n// C# program to demonstrate working of  \r\n// interface \r\nusing System; \r\n  \r\n// A simple interface \r\ninterface inter1 \r\n{ \r\n    // method having only declaration  \r\n    // not definition \r\n    void display(); \r\n} \r\n  \r\n// A class that implements interface. \r\nclass testClass : inter1 \r\n{ \r\n      \r\n    // providing the body part of function \r\n    public void display() \r\n    { \r\n        Console.WriteLine(\"Sudo Placement GeeksforGeeks\"); \r\n    } \r\n  \r\n    // Main Method \r\n    public static void Main (String []args) \r\n    { \r\n          \r\n        // Creating object \r\n        testClass t = new testClass(); \r\n          \r\n        // calling method \r\n        t.display(); \r\n    } \r\n} \r\n",
               "Eine Klasse kann mehrere Interfaces implementieren, während sie nur von einer Basisklasse erben kann. Dadurch wird die \"Mehrfachvererbung\" ermöglicht.\n\nEs wird nur definiert, welche öffentlichen Eigenschaften und Methoden eine Klasse besitzen muss, wenn sie das Interface implementiert.\n\nDurch explizite Interface-Implementierung können gleichnamige Methoden je nach Interrface anders gehandhabt haben.");
            this.InsertDataRow(dataTable,
               "ToString()",
               "Gibt einen default string zurück, der das aktuelle Objekt darstellt.\nHäufig wird die Object.ToString-Methode überschrieben, um eine geeignetere string-Darstellung eines bestimmten Typs bereitzustellen.",
               "public override string ToString ()\r\n{\r\n    return base.GetType().Name;\r\n}",
               "");
            this.InsertDataRow(dataTable,
               "Factory",
               "Ein Objekt, dessen Aufgabe es ledeglich ist, ein anderes zu erzeugen, nennt man \"Factory\". Somit ist eine Factory-Klasse nur zuständig dafür, ein Objekt zu instanziieren und es zu liefern.",
               "class ShapeFactory {\r\n\tpublic static Shape GetShape() {\r\n\t\t// M\u00F6chte ich eines Tages z.B. doch lieber einen Kreis mehr haben, muss ich dies lediglich an dieser einen Stelle \u00E4ndern\r\n\t\treturn new Rectangle();\r\n\t}\r\n}\r\n\r\nclass Programm {\r\n\tstatic void Main(string[] args) {\r\n\t\t// Die Factory-Klasse erspart uns jetzt \u00FCberall sonst im Programmcode new Shape() zu schriebn\r\n\t\tShape myShape = ShapeFactory.GetShape();\r\n\t\tmyShape.Draw();\r\n\t}\r\n}",
               "In Factory Methoden könnte man auch default Eigenschafften setzen, die bei jeder Erzeugung automatisch festgelegt werden. Wäre aber in einem Konstruktor genau so möglich.");
            this.InsertDataRow(dataTable,
               "Abstrakt",
               "Der abstract-Modifizierer gibt an, dass dem modifizierten Objekt eine Implementierung fehlt oder dass diese unvollständig ist. Der abstract-Modifizierer kann für Klassen, Methoden, Eigenschaften, Indexer und Ereignisse verwendet werden. Verwenden Sie den abstract-Modifizierer in einer Klassendeklaration, um anzugeben, dass die Klasse nur die Basisklasse für andere Klassen sein und nicht selbst instanziiert werden soll. Als abstrakt markierte Member müssen von Klassen, die von nicht abstrakten Klassen abgeleitet wurden, implementiert werden.",
               "\r\n// C# program to show the  \r\n// working of abstract class \r\nusing System; \r\n  \r\n// abstract class 'GeeksForGeeks' \r\npublic abstract class GeeksForGeeks { \r\n  \r\n    // abstract method 'gfg()' \r\n    public abstract void gfg(); \r\n      \r\n} \r\n  \r\n// class 'GeeksForGeeks' inherit \r\n// in child class 'Geek1' \r\npublic class Geek1 : GeeksForGeeks \r\n{ \r\n  \r\n    // abstract method 'gfg()'  \r\n    // declare here with  \r\n    // 'override' keyword \r\n    public override void gfg() \r\n    { \r\n        Console.WriteLine(\"class Geek1\"); \r\n    } \r\n} \r\n  \r\n// class 'GeeksForGeeks' inherit in  \r\n// another child class 'Geek2' \r\npublic class Geek2 : GeeksForGeeks \r\n{ \r\n  \r\n    // same as the previous class \r\n    public override void gfg() \r\n    { \r\n        Console.WriteLine(\"class Geek2\"); \r\n    } \r\n} \r\n  \r\n// Driver Class \r\npublic class main_method { \r\n  \r\n    // Main Method \r\n    public static void Main() \r\n    { \r\n  \r\n        // 'g' is object of class \r\n        // 'GeeksForGeeks' class ' \r\n        // GeeksForGeeks' cannot \r\n        // be instantiate \r\n        GeeksForGeeks g; \r\n  \r\n        // instantiate class 'Geek1' \r\n        g = new Geek1(); \r\n          \r\n        // call 'gfg()' of class 'Geek1' \r\n        g.gfg(); \r\n        \r\n        // instantiate class 'Geek2'   \r\n        g = new Geek2(); \r\n        \r\n        // call 'gfg()' of class 'Geek2' \r\n        g.gfg(); \r\n          \r\n    } \r\n} \r\n",
               "Von einer abstrakten Klasse kann kein Objekt erzeugt werden, sie dient ganz alleine dazu um:\n1. Copy & Paste zu vermeiden\n2. Gemeinsamkeiten zusammenzufassen und\n3. die Vorteile des Polymorphismus auszunutzen\n\nAbstrakte Methoden haben in der Basisklasse keine Funktion, vergewissern jedoch, das diese in jeder erbenden Klasse überschrieben werden bzw. funktionalität implementiert wird.\nAbstrakte Methoden können trotzdem bereits in der abstrakten Klasse aufgerufen werden. Da zur Laufzeit bei der Ausführung ein konkretes Objekt verwendet wird, dass die Methode überschrieben haben muss\n\nMit abstrakten Klassen kann man auch Arrays füllen, wodurch dieses mit den unterschiedlich instanziierten Objekten gefüllt ist. Coole Sache...");
            this.InsertDataRow(dataTable,
                "Value",
                "Das kontextabhängige Schlüsselwort value wird im set-Accessor in den Deklarationen property und indexer verwendet. Es ähnelt einem Eingabeparameter einer Methode. Das Wort value verweist auf den Wert, den Clientcode der Eigenschaft oder dem Indexer zuweisen möchte.",
                "class MyBaseClass\r\n{\r\n    // virtual auto-implemented property. Overrides can only\r\n    // provide specialized behavior if they implement get and set accessors.\r\n    public virtual string Name { get; set; }\r\n\r\n    // ordinary virtual property with backing field\r\n    private int num;\r\n    public virtual int Number\r\n    {\r\n        get { return num; }\r\n        set { num = value; }\r\n    }\r\n}\r\n\r\nclass MyDerivedClass : MyBaseClass\r\n{\r\n    private string name;\r\n\r\n   // Override auto-implemented property with ordinary property\r\n   // to provide specialized accessor behavior.\r\n    public override string Name\r\n    {\r\n        get\r\n        {\r\n            return name;\r\n        }\r\n        set\r\n        {\r\n            if (!string.IsNullOrEmpty(value))\r\n            {\r\n                name = value;\r\n            }\r\n            else\r\n            {\r\n                name = \"Unknown\";\r\n            }\r\n        }\r\n    } \r\n}",
                "");
            this.InsertDataRow(dataTable,
                "Reflexion",
                "Reflexion (englisch reflection) oder Introspektion bedeutet in der Programmierung, dass ein Programm seine eigene Struktur kennen und eventuell diese modifizieren kann. ",
                "public string GetStringProperty(Object obj, string methodName) {\r\n    string val = null;\r\n    \r\n    try {\r\n        MethodInfo methodInfo = obj.GetType().GetMethod(methodName);\r\n        val = (string)methodInfo.Invoke(obj, new Object[0]);\r\n    } catch (Exception e) {\r\n        //Fehlerbehandlung zwecks \u00DCbersichtlichkeit nicht implementiert.\r\n    }\r\n\r\n    return val;\r\n  }",
                "");
            this.InsertDataRow(dataTable,
               "Überschreiben vs. Überladen",
               "Vorab: Die \"Signatur\" ist der Methodenname PLUS die Parametern\n\n" +
               "\"Überschreiben\" ist das Implementieren einer Methode aus der Oberklasse mit identischer Signatur, aber unterschiedlichen Rückgabetypen/ Funktionalitäten\n\n" +
               "\"Überladen\" nennt man es wenn die Signatur unterschiedlich ist, die Methoden aber ansonsten den gleichen Namen haben",
               "// Überschreiben\nclass Tier{\r\n public String toString(){}\r\n}\r\n\r\nclass Hund extends Tier{\r\n public String toString(){}\r\n}\n\n" +
               "// Überladen\nclass Tier{\r\n public String toString(){}\r\n public String toString(SomeObjectType blub){}\r\n}",
               "-\tDas Wort \"Überschatten\" nicht verwenden! Evtl. andere Bedeutung?\r\n\r\n");
            this.InsertDataRow(dataTable,
               "Polymorphismus",
               "Allgemein kennzeichnet polymorph die Fähigkeit eines Objekts unterschiedliche Formen anzunehmen. Der Begriff Polymorph stammt aus dem Griechischen: Poly = viele, morph = Form. Für die objektorientierte Programmierung ist die Polymorphie ein mächtiges Werkzeug und zugleich ein zentrales Konzept jeder objektorientierten Programmiersprache. Mit polymorpher Programmierung kannst Du Interfaces in unterschiedlichen  Ausprägungen effizient realisieren. Polymorphie ermöglicht Objekten basierend auf ihrem Typ behandelt zu werden\n" +
               "Für genauere Informatinen zur Kompile- und Laufzeit siehe \"Zeittypen\" :)",
               "\r\n// C# program to demonstrate the method overriding  \r\n// without using 'virtual' and 'override' modifiers \r\nusing System; \r\n  \r\n// base class name 'baseClass' \r\nclass baseClass \r\n  \r\n{ \r\n    public void show() \r\n    { \r\n        Console.WriteLine(\"Base class\"); \r\n    } \r\n} \r\n  \r\n// derived class name 'derived' \r\n// 'baseClass' inherit here \r\nclass derived : baseClass \r\n{ \r\n      \r\n    // overriding \r\n    new public void show()  \r\n    { \r\n        Console.WriteLine(\"Derived class\"); \r\n    } \r\n} \r\n   \r\nclass GFG { \r\n      \r\n    // Main Method \r\n    public static void Main() \r\n    { \r\n          \r\n        // 'obj' is the object of \r\n        // class 'baseClass' \r\n        baseClass obj = new baseClass(); \r\n         \r\n         \r\n        // invokes the method 'show()' \r\n        // of class 'baseClass' \r\n        obj.show(); \r\n          \r\n        obj = new derived(); \r\n          \r\n        // it also invokes the method  \r\n        // 'show()' of class 'baseClass' \r\n        obj.show(); \r\n          \r\n    } \r\n} \r\n",
               "-\tWährend mit dem Überladen von Methoden alle Methoden den gleichen Namen aber unterschiedliche Argumente nutzen, erweitert die Polymorphie dieses Programmierkonzept.\r\n\r\n-\tMit dem \"new\"-Schlüsselwort kann man die \"override\" Methode der Oberklasse auswählen. Es ist nur nötig, um sicherzustellen, dass man explizit NICHT überschreiben will (Compilerding!)\r\n\r\n");
           this.InsertDataRow(dataTable,
                "Zeittypen",
                "Kompilierzeit: Der statische Typ bestimmt, welche Methoden und Eigenschaften du von deinem Objekt während der Ausführung ausführen darfst\n\n" +
                "Laufzeit: Der Laufzeittyp definiert, welcher Typ sich tatsächlich hinter dem Objekt wähend der Ausführung befindet.\n\n" +
                "Also... Welche Methoden und Eigenschaften zur Verfügung stehen, bestimmt der statische Typ zur Kompilierzeit. Die Funktion, die nun tatsächlich ausgeführt wird, wird durch den Laufzeittyp bestimmt.",
                "BasisGeist meinGeist = new SpeziellerGeist();\n" +
                "        \\                                               /\n" +
                "Kompilerzeittyp           Laufzeittyp",
                "-\tDie Kompilierzeit steht in der Hierarchie immer weiter oben als die Laaufzeit, es handelt sich also um den gleichen Typ, oder eine Basisklasse\r\n\r\n");
            this.InsertDataRow(dataTable,
                "Vererbung",
                "Vererbung ist eine Funktion der objektorientierten Programmiersprachen, die Ihnen ermöglicht, eine Basisklasse zu definieren, die eine bestimmte Funktionalität bietet (Daten und Verhalten), und abgeleitete Klassen zu definieren, die diese Funktionalität entweder übernehmen oder außer Kraft setzen.",
                "\r\n// C# program to illustrate the \r\n// concept of inheritance \r\nusing System; \r\nnamespace ConsoleApplication1 { \r\n  \r\n// Base class \r\nclass GFG { \r\n   \r\n   // data members \r\n    public string name; \r\n    public string subject; \r\n  \r\n    // public method of base class  \r\n    public void readers(string name, string subject) \r\n    { \r\n        this.name = name; \r\n        this.subject = subject; \r\n        Console.WriteLine(\"Myself: \" + name);  \r\n        Console.WriteLine(\"My Favorite Subject is: \" + subject); \r\n    } \r\n} \r\n  \r\n// inheriting the GFG class using :  \r\nclass GeeksforGeeks : GFG { \r\n   \r\n    // constructor of derived class \r\n    public GeeksforGeeks() \r\n    { \r\n        Console.WriteLine(\"GeeksforGeeks\"); \r\n    } \r\n} \r\n   \r\n// Driver class \r\nclass Sudo { \r\n  \r\n    // Main Method \r\n    static void Main(string[] args) \r\n    { \r\n   \r\n        // creating object of derived class \r\n        GeeksforGeeks g = new GeeksforGeeks(); \r\n  \r\n        // calling the method of base class  \r\n        // using the derived class object \r\n        g.readers(\"Kirti\", \"C#\"); \r\n    } \r\n} \r\n} \r\n",
                "-\tMit dem Schlüsselwort override kann man Methoden einer Oberklasse überschreiben\r\n\r\n-\tZu überschreibende Methoden einer Basisklasse müssen mit dem Schlüsselwort \"virtual\" gekennzeichnet werden\r\n\r\n-\tJEDE Klasse Erbt von Object\r\n\r\n-\t\"base\" in C# ist wie \"super\" in Jave\r\n\r\n-\tMit dem Schlüsselwort \"sealed\" kann man verhindern, dass von einer Klasse geerbt wird\r\n\r\n-\tÜberschreiben funktioniert nur vom Allgemeinen zum Speziellen und niemals umgekehrt!\r\n\r\n-\tJede Klasse darf nur EINE EINZIGE Basisklasse besitzen\r\n\r\n");
            InsertDataRow(dataTable,
                "Static",
                "Verwenden Sie den Modifizierer static, um einen statischen Member zu deklarieren, der zum Typ selbst gehört, anstatt zu einem bestimmten Objekt. Der Modifizierer static kann mit Klassen, Feldern, Methoden, Eigenschaften, Operatoren, Ereignissen und Konstruktoren verwendet werden.",
                "STATIC CLASS\r\n\r\n// C# program to illustrate the \r\n// concept of a static class \r\nusing System; \r\n  \r\n// Creating static class \r\n// Using static keyword \r\nstatic class Tutorial { \r\n  \r\n    // Static data members of Tutorial \r\n    public static string Topic = \"Static class\"; \r\n} \r\n  \r\n// Driver Class \r\npublic class GFG { \r\n  \r\n    // Main Method \r\n    static public void Main() \r\n    { \r\n  \r\n        // Accessing the static data members of Tutorial \r\n        Console.WriteLine(\"Topic name is : {0} \", Tutorial.Topic); \r\n    } \r\n} \r\n\r\n\r\nSTATIC VARIABLE\r\n\r\n// C# program to illustrate the \r\n// concept of static varaible \r\nusing System; \r\n  \r\nclass Vehicle { \r\n  \r\n    // Creating static variable \r\n    // Using static keyword \r\n    public static string Model_color = \"Black\"; \r\n} \r\n  \r\n// Driver Class \r\npublic class GFG { \r\n  \r\n    // Main Method \r\n    static public void Main() \r\n    { \r\n  \r\n        // Accessing the static variable \r\n        // using its class name \r\n        Console.WriteLine(\"Color of XY model is  : {0} \", \r\n                                    Vehicle.Model_color); \r\n    } \r\n} \r\n\r\n\r\nSTATIC METHOD\r\n\r\n// C# program to illustrate the \r\n// concept of static method \r\nusing System; \r\n  \r\nclass Nparks { \r\n  \r\n    static public int t = 104; \r\n  \r\n    // Creating static method \r\n    // Using static keyword \r\n    public static void total() \r\n    { \r\n        Console.WriteLine(\"Total number of national parks\"+ \r\n                           \" present in India is :{0}\", t); \r\n    } \r\n} \r\n  \r\n// Driver Class \r\npublic class GFG { \r\n  \r\n    // Main Method \r\n    static public void Main() \r\n    { \r\n  \r\n        // Accessing the static method \r\n        // using its class name \r\n        Nparks.total(); \r\n    } \r\n} ",
                "-\tStatische Methoden werden \u00FCber Klassen aufgerufen, nicht \u00FCber Objekte\r\n\r\n-\tStatische Sachen werden mit jedem Programmaufruf geladen unabh\u00E4ngig von ihrer Verwendung\r\n\r\n-\tStatische Methoden k\u00F6nnen nur statische Methoden aufrufen und umgekehrt\r\n\r\n-\tNicht verwendbar f\u00FCr Indexer, Finalizer oder Typen au\u00DFer Klassen");
            InsertDataRow(dataTable,
                "Konstruktor",
                "Ein Konstruktor ist die \"Geburtsmethode\" eines Objekts. Wied dieses mit \"new\" erzeugt, wird der Konstrukter aufgerufen. D.h. \"new\" macht eigentlich nichts anderes als die Konstruktormethode aufzurufen.",
                "class Person\r\n{\r\n    public Person()\r\n    {\r\n\r\n    }\r\n\r\n    public Person(string name): this (name, 0)\r\n    {\r\n\r\n    }\r\n\r\n    public Person(string name, float weight)\r\n    {\r\n        this.Name = name;\r\n        this.Weight = weight;\r\n    }\r\n\r\n    //Destruktor\r\n    ~Person() \r\n    {\r\n \r\n    }\r\n\r\n    public string Name { get; set; }\r\n    public float Weight { get; set; }\r\n}",
                "Eine Klasse kann mehrere Konstruktoren haben mit unterschiedlichen Parametern, wird gar kein Konstruktor vom\nProgrammierer geschrieben, erzeugt die Klasse einen Leeren Konstruktor ohne Parameter um das Objekt zu erzeugen." + Environment.NewLine + "Wird ein Konstruktor jeglicher Art geschrieben, wird der Zugriff auf den leeren Standartkonstruktor direkt gelöscht.\nWill man diesen dann dennoch haben, muss man ihn sich selber nochmal schreiben." + Environment.NewLine + "Jede Klassse darf jedoch nur einen  einzigen Destruktor besitzen" + Environment.NewLine + "Destruktor darf keine Parameterwerte und Rückgabewerte haben und anstatt einem Access Modifier schreibt man ein \'~\'");
            InsertDataRow(dataTable,
                "Dokumentation",
                "Der C#-Compiler verarbeitet Dokumentationskommentare in Ihrem Code und verarbeitet alle gültigen Tags um Funktionen in der Benutzerdokumentation bereitzustellen.",
                "/// <summary>\n/// This property always returns a value &lt; 1.\n/// </summary>",
                "-\tUm diese Kommentare einzusehen, it dem Cursor über die jeweilige Methode/ Eigenschaft, etc. gehen\r\n\r\n");
            InsertDataRow(dataTable,
                "Elvis-Operator",
                "\"?.\" ist der sogenannte Elvis-Operator, eine Kurzform der alten Variante. Es wird abgefragt, ob das Objekt gleich \"null\" ist, und nur dann wird die anschließende Methode oder Eigenschaft aufgerufen.",
                "Alt:\t public string Fullname {",
                "Mit C# 6-Syntax eingeführt\n\t\tget {\n\t\t\treturn String.Format(\"{0} {1}\", this.Firstname, this.Lastname);\n\t\t}\n\t}" + Environment.NewLine + "Neu:\tpublic string Fullname => $\"{this.Firstname} {this.Lastname}\"" + Environment.NewLine + Environment.NewLine + "Alt:\tPerson p = null;\n\tstring fullname = p != null ? p.Fullname : String.Empty;\n\nNeu:\tPerson p = null;\n\tstring fullname = p?.Fullname;");
            InsertDataRow(dataTable,
                "Enumerationen",
                "Ein Enumerationstyp (auch Enumeration oder enum genannt) bietet eine effiziente Möglichkeit zum Definieren\nvon benannten ganzzahligen Konstanten, die einer Variablen zugewiesen werden können.",
                "enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };",
                "Achtung! Get- und Set sind keine Methoden (wie in Java) sondern sogenannte Accessoren!");
            InsertDataRow(dataTable,
                "Getter & Setter",
                "In C# einfache Initialisierung möglich mit z.B.: \n\tpublic string FirstName { get; private set; }",
                "Ausprogrammierter Accessor: \n\tclass Person {\n\t\tpublic string FirstName {\n\t\t\tget {\n\t\t\t\treturn this.firstName;\n\t\t\t}\n\t\t\tprivate set {\n\t\t\t\tthis.firstNme = value;\n\t\t\t}\n\t\t}\n\t}",
                "Wichtig: Nur Eigenschaften bekommen Accessoren, nicht aber Variablen!");
            InsertDataRow(dataTable,
                "Nullables",
                "DatenTyp? lässt den Compiler den Datentyp in die nullable Version umwandeln. Somit darf der Datentyp null annehmen",
                "\r\n// C# program to illustrate Nullable Types \r\nusing System;  \r\n  \r\nclass Geeks {  \r\n  \r\n    // Main Method \r\n    static void Main(string[] args) \r\n    { \r\n          \r\n        // defining Nullable type \r\n        Nullable<int> n = null; \r\n  \r\n        // using the method \r\n        // output will be 0 as default  \r\n        // value of null is 0 \r\n        Console.WriteLine(n.GetValueOrDefault());  \r\n          \r\n        // defining Nullable type \r\n        int? n1 = null; \r\n  \r\n        // using the method \r\n        // output will be 0 as default  \r\n        // value of null is 0 \r\n        Console.WriteLine(n1.GetValueOrDefault());  \r\n          \r\n           \r\n        // using Nullable type syntax  \r\n        // to define non-nullable \r\n        int? n2 = 47; \r\n  \r\n        // using the method \r\n        Console.WriteLine(n2.GetValueOrDefault());  \r\n          \r\n        // using Nullable type syntax  \r\n        // to define non-nullable \r\n        Nullable<int> n3 = 457; \r\n  \r\n        // using the method \r\n        Console.WriteLine(n3.GetValueOrDefault());  \r\n          \r\n    } \r\n      \r\n}  \r\n\r\nOutput:\r\n\r\n0\r\n0\r\n47\r\n457\r\n",
                "Ab C# 8 kann man Datentypen automatisch einen null-Wert erlauben. Zu beginn der Programmdatei muss in der ersten Zeile #nullable enable stehen um diese Funktion zu aktivieren");
            InsertDataRow(dataTable,
                "Parameter",
                "Vorab: Für Schlüsselwörter wie \"in\", \"ref\" und \"out\" bitte in Referenzen schauen :)\n\n" +
                "Ein Parameter bestimmt, mit welchen Werten eine Prozedur oder Anweisung arbeitet. Um dies zu erreichen, werden der auszuführenden Prozedur hier: Methode die Parameter übergeben.",
                "\r\n// C# program to illustrate the  \r\n// concept of the named parameters \r\nusing System; \r\n  \r\npublic class GFG { \r\n  \r\n    // addstr contain three parameters \r\n    public static void addstr(string s1, string s2, string s3) \r\n    { \r\n        string result = s1 + s2 + s3; \r\n        Console.WriteLine(\"Final string is: \" + result); \r\n    } \r\n  \r\n    // Main Method \r\n    static public void Main() \r\n    { \r\n        // calling the static method with named  \r\n        // parameters without any order \r\n        addstr(s1: \"Geeks\", s2: \"for\", s3: \"Geeks\"); \r\n                     \r\n    } \r\n} \r\n",
                "Optionale Parameter: Dise stehen am Ende einer Methode und bekommen im Funktionskopf einen Wert zugewiesen: Dieser ist der Standartwert und die Methode kann nun mit oder ohne den Parameter aufgerufen werden." + Environment.NewLine + "Benannte Parameter: Bei Verwendung benannter Argumente bleibt es Ihnen erspart, sich an die Reihenfolge von Parametern in den Parameterlisten von aufgerufenen Methoden zu erinnern oder sie nachzuschauen. Der Parameter für jedes Argument kann vom Parameternamen angegeben werden" + Environment.NewLine + "params: Mithilfe dieses Schlüsselworts kann ein Methodenparameter angegeben werden, der eine variable Anzahl von Argumenten innerhalb eines Arrays akzeptiert." + Environment.NewLine + "Im grunde depricated, weil Listen bzw. Collections von sich aus bereits dynamisch sind");
            InsertDataRow(dataTable,
                "Partielle Klassen",
                "Eine Partielle Klasse ist ein Begriff aus der objektorientierten Programmierung und bezeichnet eine Vorgangsweise,\nKlassen in mehrere Quellcodedateien aufzuteilen oder an verschiedenen Orten innerhalb einer Datei zu deklarieren.",
                "// Geeks1.cs\r\n\r\npublic partial class Geeks { \r\n    private string Author_name; \r\n    private int Total_articles; \r\n  \r\n    public Geeks(string a, int t) \r\n    { \r\n        this.Authour_name = a; \r\n        this.Total_articles = t; \r\n    } \r\n} \r\n\r\n// Geeks2.cs\r\n\r\npublic partial class Geeks { \r\n    public void Display() \r\n    { \r\n        Console.WriteLine(\"Author's name is : \" + Author_name); \r\n        Console.WriteLine(\"Total number articles is : \" + Total_articles); \r\n    } \r\n} \r\n",
                "Bei der Kompilierung werden alle \"physikalischen\" partiellen Klassen zu einer \"logischen\" gesamten Klasse zusammengeführt");
            InsertDataRow(dataTable,
                "Strukturen",
                "Ein struct-Typ ist ein ein Werttyp, der in der Regel verwendet wird, um eine kleine Gruppe verwandter Variablen\nzusammenzufassen, z. B. Koordinaten eines Rechtecks oder die Merkmale eines Lagerartikels.",
                "Namenloses Beispiel:" + Environment.NewLine + "(string Name, float Amount, string Unit)[]\r\nNamelessIngredients = new (string Name, float Amount, string Unit)[2];\r\nNamelessIngredients[0] = (\"Wasser\", 0.25F, \"l\");\r\nNamelessIngredients[1] = (\"Mehl\", 30, \"g\");\r\nConsole.WriteLine($\"Zutaten: {NamelessIngredients[0].Name} und {NamelessIngredients[1].Name}\");",
                "Unterschiede zur Klasse:" + Environment.NewLine + "\t-Eine Struktur miss initialisiert sein, Klasse kann auch null sein\n\t-Werden Strukturen kopiert, hat man diese 2 Mal und nicht nur 2 Referenzen wie bei einer Klasse\n\t-Strukturen werden im Heap abgespeichert (quasi static)\n\t-Strukturen können weder vererbt werden, noch selber erben\n\t-Strukturen müssen keinen Namen haben" + Environment.NewLine + "=> Strukturen sind wie primitive Datentypen, nur dass sie aus mehreren Werten bestehen können.\nMit den Schlüsselwörtern \"ref\" und \"in\" lassen sich sogar deren Nachteile aushebeln!" + Environment.NewLine + "ACHTUNG: Trotzdem muss eine Struktur mit \"new\" initialisiert werden");
            InsertDataRow(dataTable,
                "String",
                "Strings sind Quasi ein Array aus Zeichenketten und müssen i.d.R. durch doppelte Hochkommas eingeschlossen sein. In C# gibt es string auch als primitiven Datentyp.",
                "// C# program to declare string using \r\n// string, String and System.String \r\n// and intialzation of string \r\nusing System; \r\nclass Geeks { \r\n  \r\n    // Main Method \r\n    static void Main(string[] args) \r\n    { \r\n  \r\n        // declare a string Name using  \r\n        // \"System.String\" class \r\n        System.String Name; \r\n          \r\n        // intialzation of String \r\n        Name = \"Geek\"; \r\n  \r\n  \r\n        // declare a string id using  \r\n        // using an alias(shorthand)  \r\n        // \"String\" of System.String \r\n        // class \r\n        String id; \r\n          \r\n        // intialzation of String \r\n        id = \"33\"; \r\n  \r\n        // declare a string mrk using  \r\n        // string keyword \r\n        string mrk; \r\n          \r\n        // intialzation of String \r\n        mrk = \"97\"; \r\n          \r\n        // Declaration and intialzation of \r\n        // the string in a single line \r\n        string rank = \"1\"; \r\n  \r\n        // Displaying Result \r\n        Console.WriteLine(\"Name: {0}\", Name); \r\n        Console.WriteLine(\"Id: {0}\", id); \r\n        Console.WriteLine(\"Marks: {0}\", mrk); \r\n        Console.WriteLine(\"Rank: {0}\", rank); \r\n    } \r\n} \r\n",
                "Composite formatting:\nConsole.WriteLine(\"Hello, {0}! Today is {1}, it's {2:HH:mm} now.\", name, date.DayOfWeek, date);\n\n// String interpolation:\nConsole.WriteLine($\"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.\"); \n\n-\tMit einem @ vor einem String, kann man sich die nötigen Doppelbackslashes bei einer Pfadangabe sparen\r\n\r\n");
            InsertDataRow(dataTable,
                "Singleton",
                "Das Singleton ist ein in der Softwareentwicklung eingesetztes Entwurfsmuster und gehört zur Kategorie der Erzeugungsmuster. Es stellt sicher, dass von einer Klasse genau ein Objekt existiert.",
                "class MySingleton {\r\n" + "\tstatic MySingleton obj;\r\n" + "\tprivate MySingleton() {\r\n" + "\t}\r\n" + "\tpublic static MySingleton GetSongleton() {\r\n" + "\t\tif (obj == null)\r\n" + "\t\t\tobj = new MySingleton();\r\n" + "\t\treturn obj;\r\n" + "\t}\r\n" + "}\r\n",
                "Auch verwendet, wenn das einzige Objekt durch Unterklassenbildung spezialisiert werden soll");
            InsertDataRow(dataTable,
                "Referenzen",
                "Bei einem Methodenaufruf werden die Parameter nur als Kopie übergeben (call-by-value) und das Original kann somit nicht verändert werden. Möchte man das umgehen, kann man \"Refernzschlüsselwörter\" vrwenden und z.B. durch \"ref\" ein call-by-reference erzwingen.",
                "Ref:\nZahl zu beginn: 5\npublic void OutBeispiel (ref int zahlRef, int zahlNormal) \n\t{ \n\t\tzahlRef *= 2; \n\t\tzahlNormal *= 2; \n\t}\nZahl die normal übergeben wurde:  5\nZahl die mit ref übergeben wurde: 10\nOut:\npublic void OutBeispiel()\n\t{\n\t\tInt32.TryParse(\"5\", out int zahl);\n\t\tConsole.WriteLine(zahl);\n\t}\nHier wird 5 ausgegeben, obwohl Zahl nie initialisiert wurde\nIn:\nstatic void ReadOnly(in int a)\n\t{\n\t\tint temp = a\t<-- das wäre möglich\n\t\ta=b\t\t<-- das ist gesperrt\n\t}",
                "ACHTUNG! Wird ein Parameter per ref oder out übergeben, so wird die Vererbung nicht unterstützt und du brauchst für jeden Typ eine eigene Funkitionsüberladung\r\n\r\nAls rückgabetyp kann ref verwendet werden, um eine Referenz zurückzugeben, bzw. den Verweis auf ein Wert/ Objekt" + Environment.NewLine + "Unsicher und unübersichtlich, lieber nicht verwenden! Spiele nicht am Speicher!");
            InsertDataRow(dataTable,
                "Namespaces",
                "Das namespace-Schlüsselwort wird verwendet, um einen Gültigkeitsbereich zu deklarieren, der eine Gruppe von verwandten Objekten enthält. Sie können einen Namespace verwenden, um Codeelemente zu organisieren und global eindeutige Typen zu erstellen.",
                "namespace Schublade.Mappe {" + Environment.NewLine + "\t//Hier findest du deine Klasse" + Environment.NewLine + "\tclass Zettel { }" + Environment.NewLine + "}",
                "- Vermeidung von Namenskonflikten" + Environment.NewLine + "- Namespace-Ebenen werden mit Punkten getrennt" + Environment.NewLine + "Namespaces werden mittels \"using\" eingebunden, dadurch keine Punktnotation mehr nötig" + Environment.NewLine + " - using T = System.Threading.Tasks; möglich" + Environment.NewLine + "- Verweise auf ein Assembly für \"automatisches using \"" + Environment.NewLine + "- Ab C#6 auch Einbindung von statischen Klassen so möglich (Bsp. using static System.Math)");
            InsertDataRow(dataTable,
                "IntelliSense",
                "IntelliSense ist ein von Microsoft angebotenes Hilfsmittel zur automatischen Vervollständigung bei der Bearbeitung von Quellcode durch einen Programmierer.",
                "String. \nIntellisense zeigt nun Methoden auf, die für String zur Verfügung stehen",
                "Durch Steuerung + Leertaste lassen sich Methoden, Eigenschaften, etc. bereits vor der Punktnotation anzeigen :)\nÄhnliche Funktionen finden sich in nahezu allen fortgeschrittenen Entwicklungsumgebungen, z.B. Conent Assist mit Eclipse für Java");
            InsertDataRow(dataTable,
                "C#",
                "C# (englisch c sharp [siːˈʃɑːp]) ist eine typsichere, objektorientierte Allzweck-Programmiersprache. Architekt der Sprache ist Anders Hejlsberg im Auftrag von Microsoft. Die Sprache ist an sich plattformunabhängig, wurde aber im Rahmen der .NET-Strategie entwickelt, ist auf diese optimiert und meist in deren Kontext zu finden. ",
                "\r\n// C# program to print Hello World! \r\nusing System; \r\n  \r\n// namespace declaration \r\nnamespace HelloWorldApp { \r\n      \r\n    // Class declaration \r\n    class Geeks { \r\n          \r\n        // Main Method \r\n        static void Main(string[] args) { \r\n              \r\n            // statement \r\n            // printing Hello World! \r\n            Console.WriteLine(\"Hello World!\"); \r\n              \r\n            // To prevents the screen from  \r\n            // running and closing quickly \r\n            Console.ReadKey(); \r\n        } \r\n    } \r\n} \r\n",
                "-\tErscheinungsjahr 2001\r\n\r\n-\tBeeinflusst durch Java, C++, und Object Pascal\r\n\r\n");
        }

        #endregion

        #region Methods

        public DataRow InsertDataRow (DataTable dataTable, String query, String description, String example, String information)
        {
            
            var dataRow = dataTable.NewRow();
            dataRow["query"] = query;
            dataRow["description"] = description;
            dataRow["example"] = example;
            dataRow["information"] = information;
            dataTable.Rows.Add(dataRow);

            return dataRow;
        }

        public DataTable CreateTable ()
        {
            var dataTable = new DataTable("DataTable");
            dataTable.Columns.Add("query");
            dataTable.Columns.Add("description");
            dataTable.Columns.Add("example");
            dataTable.Columns.Add("information");

            return dataTable;
        }

        #endregion
    }
}
