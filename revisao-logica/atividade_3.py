from decimal import Decimal

def main(): 
    try:
        print("Por favor informar dados reais abaixo para serem calculados:")
        value_x = Decimal(input('X: ').replace(',','.'))
        value_y = Decimal(input('Y: ').replace(',','.'))

        math_operation = int(input('Escolha uma operação matematica \n 1 - Somar \n 2 - Subtrair \n 3 - Multiplicar \n 4 - Dividir \n Opção:'))
        math_result = 0

        if (math_operation == 1):
            math_result = value_x + value_y
        elif (math_operation == 2):
            math_result = value_x - value_y
        elif (math_operation == 3):
            math_result = value_x * value_y
        elif (math_operation == 4):
            math_result = value_x / value_y
        else:
            print('A operação matematica não foi encontrada')
            return

        print(f'O resultado da sua operação matematica foi: {math_result}')
    except:
        print(f'Não foi possivel fazer a operação matematica')

main()