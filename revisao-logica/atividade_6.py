def main(): 
    try:
        print("Por favor informe um numero inteiro abaixo:")
        value = int(input('Numero: '))
        
        if (value <= 0):
            print('O numero escolhido deve ser maior que zero')
            return
        
        for i in range(2, int(value / 2) + 1):

            if (value % i == 0):
                print(f'O numero {value} não é um numero primo')
                return

        print(f'O numero {value} é um numero primo')

    except:
        print(f'Não foi possivel validar se o numero é primo')

main()