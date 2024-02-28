def sum_all(values):
    total = 0
    for i in values:
        total += i
    return total

def main(): 
    try:
        print("Por favor informe os valores abaixo:")
        
        values = []
        for i in range(0, 10):
            value = int(input(f'Informe a posição {i+1} do vetor: '))
            values.append(value)

        pair = []
        odd = []

        for i in values:
            if (i%2==0):
                pair.append(i)
            else:
                odd.append(i)

        print(f'Foram informados {len(pair)} numero pares e {len(odd)} numeros impares')
        print(f'A soma dos numero pares é {sum_all(pair)}')
        print(f'A media dos numeros impares é {sum_all(odd)/len(odd)}')
            
    except:
        print(f'Não foi possivel fazer calculos devido ao erro interno')

main()