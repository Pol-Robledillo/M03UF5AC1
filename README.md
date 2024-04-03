# M03UF5AC1
## Fuentes
- Contributors to Wikimedia projects. (2024, 6 enero). Alfabet grec. Viquipèdia, L’enciclopèdia Lliure. (https://ca.wikipedia.org/wiki/Alfabet_grec)
- ChatGPT. (s. f.-b). (https://chat.openai.com/)
## IAs
Prompt:
- Haz un regex para que un string solo pueda empezar por el nombre de una consonante griega, seguida de un guión y 3 números.

Respuesta(Chat GPT):
- Puedes usar la siguiente expresión regular para validar un string que comience con el nombre de una consonante griega seguida de un guión y tres números:

^(alpha|beta|gamma|delta|epsilon|zeta|eta|theta|iota|kappa|lambda|mu|nu|xi|omicron|pi|rho|sigma|tau|upsilon|phi|chi|psi|omega)-\d{3}$

Esta expresión regular incluye los nombres de las consonantes griegas en inglés y requiere que el string comience con uno de esos nombres seguido de un guión y tres números. Puedes modificarla según tus necesidades específicas.

Prompt:
- Cuales son las consonantes del alfabeto griego?

Respuesta(Chat GPT):
- En el alfabeto griego, las consonantes son las siguientes:

β (Beta),
γ (Gamma),
δ (Delta),
ζ (Zeta),
θ (Theta),
κ (Kappa),
λ (Lambda),
μ (Mu),
ν (Nu),
ξ (Xi),
π (Pi),
ρ (Rho),
σ (Sigma),
τ (Tau),
φ (Phi),
χ (Chi),
ψ (Psi)

Estas son las consonantes del alfabeto griego estándar. Puedes usar cualquiera de ellas en la expresión regular para validar un string que empiece con una de estas consonantes seguida de un guión y tres números.

Prompt: 
~~~
Regex regex
~~~
Respuesta(Copilot):
~~~
Regex regex = new Regex(@"^[a-zA-Z0-9]+$");
~~~
(En la practica he quitado el 0-9 porque no se pueden poner numeros en ese campo)
