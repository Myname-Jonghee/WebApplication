  [HttpGet]
  public IActionResult SignUp()
  {
      return View();
  }
  [HttpPost]
  public async Task<IActionResult> SignUp(Sign_Up model)
  {

      if (ModelState.IsValid)
      {
          // 비밀번호와 비밀번호 확인이 일치하는지 확인
          if (model.Password != model.ConfirmPassword)
          {
              // 비밀번호가 일치하지 않을 경우 오류 메시지를 추가
              ModelState.AddModelError("ConfirmPassword", "비밀번호가 일치하지 않습니다.");
              return View(model); // 오류가 있으면 다시 해당 뷰로 이동
          }

          // 비밀번호를 그대로 저장
          model.Password = model.Password;
          model.ConfirmPassword = model.ConfirmPassword;

          // 데이터베이스에 추가
          _context.Sign_Up.Add(model);
          await _context.SaveChangesAsync();

          return RedirectToAction("Index");
      }

      return View(model);
  }
