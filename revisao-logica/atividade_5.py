def main(): 
    try:
        print("Por favor informar dois numeros inteiros abaixo:")
        value_x = int(input('X: '))
        value_y = int(input('Y: '))

        for value_x in range(value_x, value_y + 1):
            print('----------------------')
            print(f'Tabuada do {value_x}')
            for i in range(1, 11):
                print(f'{value_x} x {i} = {value_x*i}')
            print('----------------------\n')

    except:
        print(f'Não foi possivel exibir a tabuada dos numeros informados')

main()