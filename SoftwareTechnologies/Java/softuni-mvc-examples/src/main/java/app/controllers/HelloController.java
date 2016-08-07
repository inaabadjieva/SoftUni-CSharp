package app.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.Date;

@Controller
public class HelloController {
    @RequestMapping("/hello")
    public String hello(Model model){
        model.addAttribute("msg", "Hello");
        model.addAttribute("date", new Date().toString());
        return "hello-view";
    }

    @RequestMapping("/numbers")
    public String numbers(Model model){
        return "numbers";
    }

    @RequestMapping("/main")
    public String main(Model model){
        return "main";
    }
}
