def fat(fatorial_number):

    if (fatorial_number == 0):
        return 0

    if (fatorial_number == 1):
        return fatorial_number
    
    return fat(fatorial_number-1) * fatorial_number

def main(): 
    try:
        print("Por favor informe o valor para o calculo da fatorial:")
        value = int(input(''))

        fatorial = fat(value)
        print(f'O valor fatorial é: {fatorial}')
    except:
        print(f'Não foi possivel fazer fatorial')

main()