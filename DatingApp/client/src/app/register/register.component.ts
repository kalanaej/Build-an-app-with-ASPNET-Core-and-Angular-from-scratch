import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  @Input() usersFromHomeComponent: any;

  // EventEmitter should come from Angular/Core package. Not from other packages
  @Output() cancelRegister = new EventEmitter

  model: any = {};

  constructor() { }

  ngOnInit(): void {
  }

  register() {
    console.log(this.model);
  }

  cancel() {
    this.cancelRegister.emit(false);
  }

}
