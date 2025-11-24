
Console.WriteLine("Informe o tipo de carro (popular ou luxo):");
        var tipoCarro = Console.ReadLine();

        Console.WriteLine("Informe a quantidade de dias de aluguel:");
        var dias = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de Km percorridos:");
        double kmPercorridos = Convert.ToSingle(Console.ReadLine());

        double precoDia = 0;
        double precoKm = 0;

        if (tipoCarro == "popular")
        {
            precoDia = 90;
            if (kmPercorridos <= 100)
            {
                precoKm = kmPercorridos * 0.20;
            }
            else
            {
                precoKm = kmPercorridos * 0.10;
            }
        }
        else if (tipoCarro == "luxo")
        {
            precoDia = 150;
            if (kmPercorridos <= 200)
            {
                precoKm = kmPercorridos * 0.30;
            }
            else
            {
                precoKm = kmPercorridos * 0.25;
            }
        }
        else
        {
            Console.WriteLine("Tipo de carro inválido!");
            return;
        }

        var total = (dias * precoDia) + precoKm;

        Console.WriteLine($"O preço total a pagar é: R${total:F2}");
