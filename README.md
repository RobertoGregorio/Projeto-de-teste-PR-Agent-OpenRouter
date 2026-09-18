# PR-Agent + OpenRouter Free Test

Repositório mínimo para testar revisão de Pull Requests com:

- GitHub Actions
- PR-Agent
- OpenRouter
- um modelo gratuito selecionado por `openrouter/free`
- .NET 8
- xUnit

## Configuração

1. Crie um repositório no GitHub.
2. Suba estes arquivos.
3. Em `Settings -> Secrets and variables -> Actions`, crie:
   - Name: `OPENROUTER_API_KEY`
   - Value: sua API key do OpenRouter.
4. Abra um Pull Request.
5. O workflow `AI Code Review` deverá executar e comentar no PR.

## Teste da IA

Depois que a branch `main` estiver funcionando, crie uma branch:

```bash
git checkout -b test/ai-review
```

Altere `src/PrAgentTest/Calculator.cs` para introduzir um problema real,
por exemplo removendo a validação de divisor zero:

```csharp
public decimal Divide(decimal dividend, decimal divisor)
{
    return dividend / divisor;
}
```

Faça commit, push e abra um PR.

O objetivo é observar se o PR-Agent identifica o risco.

## Observação

`openrouter/free` é um roteador para modelos gratuitos disponíveis no
OpenRouter. O modelo/provedor escolhido pode mudar ao longo do tempo.
