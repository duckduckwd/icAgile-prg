class BankAccount:

    def __init__(self, customer_name, account_no, balance):
        self.__customer_name = customer_name
        self.__account_no = account_no
        self.__balance = balance

    def deposit(self, amt):
        self.__balance += amt

    def withdraw(self, amt):
        self.__balance -= amt
