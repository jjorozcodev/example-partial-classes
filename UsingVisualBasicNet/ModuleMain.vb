Module ModuleMain

    Sub Main()
        Dim person As Person = TakePersonalInfo()

        ShowCalculating(person)
    End Sub

    Private Function TakePersonalInfo() As Person
        Dim person As New Person()

        Console.Clear()
        Console.WriteLine("Welcome!")
        Console.WriteLine("--------------------------")
        Console.WriteLine("What's your full name?")
        person.FullName = Console.ReadLine()
        person.UsualCurrency = "USD"
        Console.WriteLine("What's your goal? (USD)")
        person.Goal = Convert.ToDecimal(Console.ReadLine())
        Console.WriteLine("How many months do you want to save money?")
        person.MonthsToSave = Convert.ToInt32(Console.ReadLine())

        Return person
    End Function

    Private Sub ShowCalculating(ByRef p As Person)
        Console.Clear()
        Console.WriteLine("Well, " & p.FullName & "!")
        Console.WriteLine("--------------------------")
        Console.WriteLine("Your Goal is: " & p.UsualCurrency & " " & p.Goal.ToString())
        Console.WriteLine("After " & p.MonthsToSave & " months you'll reach your goal is you save " & p.UsualCurrency + " " & p.GetMyAmount().ToString() & " every month!")
        Console.WriteLine("--------------------------")
        Console.ReadKey()
    End Sub

End Module
