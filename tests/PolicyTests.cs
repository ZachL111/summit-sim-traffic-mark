using SummitSimTrafficMark;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(86, 93, 8, 20, 4);
        if (Policy.Score(signalcase_1) != 173) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "accept") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(65, 90, 9, 20, 13);
        if (Policy.Score(signalcase_2) != 180) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(71, 97, 20, 24, 9);
        if (Policy.Score(signalcase_3) != 133) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
