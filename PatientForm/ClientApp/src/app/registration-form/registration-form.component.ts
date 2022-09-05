import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-registration-form',
  templateUrl: './registration-form.component.html',
  styleUrls: ['./registration-form.component.css']
})
export class RegistrationFormComponent implements OnInit {

  registerationForm : FormGroup;

  constructor(private fb : FormBuilder) { }

  gender!: string;
  country!: string;
  contactType !: string;
  // = ["male", "female", "undisclosed"]
  
  ngOnInit() {

    this.registerationForm = this.fb.group(
      {

      }
    )
  }

}
