import random

def percent(possibilites, value):
    return (100 * value)/possibilites

def main(): 
    try:
        vector = []
        possibilities = 1000

        for i in range(0, possibilities):
            vector.append(random.randint(0, 1000))

        quantity = 0
        for i in vector:
            if (i >= 700):
                quantity += 1
        
        print(f'Quantidade de numeros iguais ou maiores encontrado(s) foi {quantity}')
        print(f'A porcentagem de numeros iguais ou maiores a 700 é {percent(possibilities, quantity)}%')
            
    except:
        print(f'Não foi possivel fazer calculos devido ao erro interno')

main()