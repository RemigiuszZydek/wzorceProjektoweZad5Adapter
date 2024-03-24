using System;


delegate void Logger(string message);


class IstniejacySystem {
    public void Log(string message) {
        Console.WriteLine("Log z istniejącego systemu: " + message);
    }
}

class NowaBibliotekaRejestrowania {
    public void LogMessage(string message) {
        Console.WriteLine("Log z nowej biblioteki rejestrowania: " + message);
    }
}

class LogAdapter {
    private Logger logger;

    public LogAdapter(Logger logger) {
        this.logger = logger;
    }

    public void LogMessage(string message) {
        logger(message);
    }
}


class Program {
    static void Main(string[] args) {
        IstniejacySystem istniejacySystem = new IstniejacySystem();
        NowaBibliotekaRejestrowania nowaBiblioteka = new NowaBibliotekaRejestrowania();

        
        LogAdapter adapter = new LogAdapter(istniejacySystem.Log);
        adapter.LogMessage("Przykładowa wiadomość zarejestrowana za pomocą adaptera");

      
        adapter = new LogAdapter(nowaBiblioteka.LogMessage);
        adapter.LogMessage("Inna wiadomość zarejestrowana za pomocą adaptera");
    }
}
