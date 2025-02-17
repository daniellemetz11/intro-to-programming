import { Component, ChangeDetectionStrategy, signal } from '@angular/core';

@Component({
  selector: 'app-login-status',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: ``,
  styles: ``,
})
export class LoginStatusComponent {
  isLoggedIn = signal(true);
  userName = signal('Bob@Aol.com');
}
