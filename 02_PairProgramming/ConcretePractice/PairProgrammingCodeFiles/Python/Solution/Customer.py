class Customer:
    customer_id = 1000000

    def __init__(self, first_name, last_name, email):
        self.__customer_id = customer_id + 1
        self.__first_name = first_name
        self.__last_name = last_name
        self.__email = email

        customer_id += 1

    def get_first_name(self):
        return self.__first_name

    def get_last_name(self):
        return self.__last_name

    def get_full_name(self):
        full_name = self.__first_name, " ", self.__last_name
        return full_name

    def get_email(self):
        return self.__email

    def get_customer_id(self):
        return self.__customer_id

    def set_first_name(self, new_first_name):
        self.__firstName = new_first_name

    def set_last_name(self, new_last_name):
        self.__last_name = new_last_name

    def set_email(self, new_email):
        self.__email = new_email
