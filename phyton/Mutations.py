def mutate_string(string, position, character):
    l = [char for char in string]
    l[position] = character
    return "".join(l)