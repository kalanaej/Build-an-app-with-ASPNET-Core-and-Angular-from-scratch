import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit{
  title = 'The Dating App';
  users: any;

  // make http request to an API asyncronizly.  
  constructor(private accountService: AccountService) {}

  ngOnInit()
  {
    this.setCurrentUser();
  }

  setCurrentUser() {

    // Always looged in without username fixed here
    // If you used undefined keyword that told in Q/A section, apply below edit to the code
    const user: User = JSON.parse(localStorage.getItem('user')!);
    this.accountService.setCurrentUser(user);
  }
}
