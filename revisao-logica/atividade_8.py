def get_digit_value(cpf, algorithm):
    digit_value = 0 

    for index in range(0, len(algorithm)):
        digit_value += int(cpf[index]) * algorithm[index]

    digit_value = digit_value % 11
    
    if (digit_value < 2):
        digit_value = 0
    else:
        digit_value = 11 - digit_value

    return digit_value

def main(): 
    try:
        print("Por favor informe um CPF:")
        value = input('').replace('.', '').replace('-', '')

        cpf = [*value]
        algorithm_1 = [10, 9, 8, 7, 6, 5, 4, 3, 2]
        algorithm_2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2]

        valid_digit = f'{cpf[9]}{cpf[10]}'
        calculated_digit = f'{get_digit_value(cpf, algorithm_1)}{get_digit_value(cpf, algorithm_2)}'

        if (valid_digit == calculated_digit):
            print("CPF Informado é valido")
        else:
            print("CPF Informado não é valido")

    except:
        print(f'Não foi possivel validar se o CPF era valido')

main()