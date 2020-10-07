import { FormControl } from '@angular/forms';

export function validateEmail(control: FormControl) {
    if (typeof (control.value) === 'string') {
        if (control.value.includes('@')) {
            return null;
        } else {
            return { validateEmail: { valid: false } };
        }
    }
}
