[HttpGet]
public IActionResult IMC()
{
    return View();
}

[HttpPost]
public IActionResult IMC(IMCModel model)
{
    if (model.Altura <= 0)
    {
        ModelState.AddModelError("", "La altura debe ser mayor que 0.");
        return View(model);
    }

    model.ResultadoIMC = model.Peso / (model.Altura * model.Altura);

    return View(model);
}