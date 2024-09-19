/*Polimorfismo é um conceito de orientação a objetos, é a capacidade
de um objeto mudar de "forma". Quando  uma classe que tem herança, é 
possível transformar objetos criados por essa classe em outro tipo herdado,
sendo possível reaproveitar e otimizar códigos, o simplificando e podendo
tratar diferentes tipos de objetos de maneira uniforme.
O polimorfismo pode se tornar complexo de se trabalhar quando no 
código existe muitas heranças sendo implementadas, podendo ser 
difícil rastrear qual classe ou método está sendo executado, e com
muito polimorfismo, pode ferir o design do próprio código, o
tornando mais complexo de se entender se as relações entre classes
não forem bem definidas*/

//EXEMPLO DE POLIMORFISMO POR OVERRIDE//

class Fruta
{
    public virtual void Cor()
    {
        Console.WriteLine("Uma fruta qualquer pode ter certa cor.");
    }
}
class Banana : Fruta
{
    public override void Cor()
    {
        Console.WriteLine("A banana é amarela.");
    }
}
