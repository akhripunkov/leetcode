// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine(CanCompleteCircuit(new []{1,2,3,4,5}, new []{3,4,5,1,2}));

int CanCompleteCircuit(int[] gas, int[] cost)
{
    var tank = 0;
    var total = 0;
    var pos = 0;
    for (int i = 0; i < gas.Length; i++)
    {
        tank += gas[i] - cost[i];
        total += gas[i] - cost[i];

        if (tank < 0)
        {
            pos = i + 1;
            tank = 0;
        }
    }

    return total >= 0 ? pos : -1;
}