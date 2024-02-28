def main():
    print("Por favor informar os dados abaixo")
    
    name = input('Nome:')
    address = input('Endereço:')
    date = input('Data de Entrega:')
    total_value = input('Valor da Compra:')

    print('                                 AVISO                                ')
    print(f'Caro cliente Sr(a) {name}, os produtos da sua compra no')
    print(f'valor de R$ {total_value} serão entregues no endereço abaixo:')
    print(f'Rua {address}.')
    print(f'Data da Entrega: {date}.')
    print('******************** Obrigado pela Preferência! **********************')

main()