using CopperSimSchedulerLab;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(79, 92, 19, 16, 5);
        if (Policy.Score(signalcase_1) != 149) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(92, 73, 8, 15, 13);
        if (Policy.Score(signalcase_2) != 225) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(67, 105, 19, 7, 4);
        if (Policy.Score(signalcase_3) != 170) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
