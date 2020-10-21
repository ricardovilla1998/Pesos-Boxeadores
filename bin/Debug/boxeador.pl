:-dynamic boxeador/1.
:-dynamic peso_welter/1.
:-dynamic peso_medio/1.
:-dynamic peso_pesado/1.
:-dynamic mexicano/1.
:-dynamic americano/1.


boxeador(errol_spence).
boxeador(jorge_cota).
boxeador(daniel_jacobs).
boxeador(jaime_munguia).
boxeador(saul_alvarez).
boxeador(trevor_bryan).
boxeador(andy_ruiz).


peso_welter(errol_spence).
peso_welter(jorge_cota).

peso_medio(daniel_jacobs).
peso_medio(jaime_munguia).
peso_medio(saul_alvarez).

peso_pesado(trevor_bryan).
peso_pesado(andy_ruiz).



mexicano(jorge_cota).
mexicano(jaime_munguia).
mexicano(saul_alvarez).

americano(errol_spence).
americano(daniel_jacobs).
americano(trevor_bryan).
americano(andy_ruiz).


cargar(A):-exists_file(A),consult(A).

peso_welter_mexicano(X):-boxeador(X),peso_welter(X),mexicano(X).

peso_medio_mexicano(X):-boxeador(X),peso_medio(X),mexicano(X).

peso_welter_americano(X):-boxeador(X),peso_welter(X),americano(X).

peso_medio_americano(X):-boxeador(X),peso_medio(X),americano(X).

peso_pesado_americano(X):-boxeador(X),peso_pesado(X),americano(X).











