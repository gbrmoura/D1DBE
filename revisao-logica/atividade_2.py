from decimal import Decimal

def main(): 
    try:
        print("Por favor informar os dados abaixo")
        weight = Decimal(input('Peso (KG): ').replace(',','.'))
        height = Decimal(input('altura (M): ').replace(',','.'))

        imc_value = weight / (height * height)
        img_description = ''

        if (imc_value <= 16.5):
            img_description = 'Desnutrição'
        elif (imc_value >= 16.6 and imc_value <= 18.5):
            img_description = 'Abaixo do peso'
        elif (imc_value >= 18.6 and imc_value <= 24.9):
            img_description = 'Peso normal'
        elif (imc_value >= 25 and imc_value <= 29.9):
            img_description = 'Sobrepeso'
        elif (imc_value >= 30):
            img_description = 'Obesidade'
        else:
            img_description = 'IMC Inválido'


        print(f'Seu Indice de Massa Corporal (IMC) esta classificado em: {img_description}')
    except:
        print(f'Erro ao calcular IMC')

main()